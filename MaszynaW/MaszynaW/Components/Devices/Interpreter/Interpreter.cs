using System;
using System.Collections.Generic;
using System.IO;
using MaszynaW.Bitwords;
using MaszynaW.Components.Accumulators;
using MaszynaW.Components.Memories;
using MaszynaW.Components.Registers.Counters;
using MaszynaW.Connections.Buses;

namespace MaszynaW.MaszynaW.Components.Devices
{
    class Interpreter : Device
    {
        private readonly Machine Machine;
        private readonly Bus AddrBus;
        private readonly Bus DataBus;
        private readonly int AddrLength;
        private readonly int DataLength;
        private readonly Memory Memory;
        private readonly Counter Counter;
        private readonly Accumulator Accumulator;
        private List<Order> orderList;

        public Interpreter(int wordLength, int addrLength, Machine machine, Bus addrBus, Bus dataBus, Memory memory, Counter counter, Accumulator accumulator) : base(wordLength)
        {
            Machine = machine;
            AddrLength = addrLength;
            DataLength = WordLength - AddrLength;
            AddrBus = addrBus;
            DataBus = dataBus;
            Memory = memory;
            Counter = counter;
            Accumulator = accumulator;
            orderList = new List<Order>();
            LoadOrders();
        }

        internal void CompileProgram(string sourcecode)
        {
            Memory.Format(); //reset machine
            this.Clear();
            Accumulator.HardClear();
            Counter.Clear();
            var sourcelines = sourcecode.ToLower().Split(new[] { '\r', '\n' });
            List<KeyValuePair<string, int>> tablicaEtykiet = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < sourcelines.Length; ++i)
            {
                sourcelines[i] = sourcelines[i].Trim();
                if(sourcelines[i].Contains(":"))
                {
                    string nazwaEtykiety = sourcelines[i].Split(':')[0];
                    int index = i;
                    tablicaEtykiet.Add(new KeyValuePair<string, int>(nazwaEtykiety, index));
                    sourcelines[i] = sourcelines[i].Substring(sourcelines[i].IndexOf(':') + 1); //usuwamy colony i wszystko co na lewo
                }
            }
            //mamy dodane etykiety do tablicy etykiet i kod zrodlowy oczyszczony z dwukropkow, wszystkie litery male
            List<int> tempMemory = new List<int>();
            for(int i = 0; i < sourcelines.Length; ++i)
            {
                string line = sourcelines[i].Trim();
                switch(line.Split()[0])
                {
                    case "stp":
                        {
                            tempMemory.Add(0);
                            break;
                        }
                    case "rpa":
                        {
                            tempMemory.Add(0);
                            break;
                        }
                    case "rst":
                        {
                            tempMemory.Add(Int32.Parse(line.Split()[1]));
                            break;
                        }
                    default:
                        {
                            string ordername = line.Split()[0];
                            int compiledOrder = 0;
                            foreach (var order in orderList)
                                if (order.OrderName == ordername)
                                {
                                    compiledOrder = order.OrderID;
                                    compiledOrder = compiledOrder << DataLength;
                                    if(order.NumberOfArguments == 1) //sczytujemy argument
                                    {
                                        try
                                        {
                                            string argument = sourcelines[i]?.Split()[1];
                                            if (Int32.TryParse(argument, out int numericArgument))
                                            {
                                                compiledOrder += numericArgument;
                                            }
                                            else //jesli argumentem nie jest liczba, sprawdz czy nie jest etykieta
                                            {
                                                foreach (var pair in tablicaEtykiet)
                                                {
                                                    if (pair.Key == argument)
                                                    {
                                                        compiledOrder += pair.Value;
                                                    }
                                                }
                                            }
                                        }
                                        catch (IndexOutOfRangeException) { };
                                    }
                                    break;
                                }
                            tempMemory.Add(compiledOrder);
                            break;
                        }
                }
            }
            Memory.LoadProgram(tempMemory);
        }

        private void Clear()
        {
            this.content.Clear();
        }

        internal InterpreterState GetState()
        {
            InterpreterState temp = new InterpreterState
            {
                State = content.Get(),
                OrderNumber = CalculateOrderCode(),
                OrderArgument = CalculateOrderArgumet()
            };
            return temp;
        }

        private int CalculateOrderArgumet()
        {
            int orderNumeric = content.Get();
            int orderArgument = orderNumeric << (32 - AddrLength) >> (32 - AddrLength);
            return orderArgument;
        }

        private int CalculateOrderCode()
        {
            int orderNumeric = content.Get();
            int orderCode = orderNumeric >> DataLength;
            return orderCode;
        }

        public void RunProgram()
        {
            int orderCode;
            do
            {
                Memory.SIGNAL_CZYT();
                Memory.SIGNAL_WYS();
                SIGNAL_WEI();
                orderCode = CalculateOrderCode();
                int orderArgument = CalculateOrderArgumet();
                FinishTick();
                foreach (var element in orderList)
                {
                    if (element.OrderID == orderCode) //gdy znajdziesz pasujacy rozkaz
                    {
                        Execute(element); //wykonaj rozkaz
                        break;
                    }
                }
            }
            while (orderCode != 0);
        }

        private void Execute(Order element) //w rozkazie wykonaj wsyzstkie takty
        {
            foreach(var tick in element.TickList)
            {
                Execute(tick);
            }
        }

        private void Execute(Tick tick)
        {
            var signals = tick.SignalsTable;
            if (signals[0]) { return; } //stp
            if (signals[1]) { Memory.SIGNAL_PISZ(); } //pisz
            if (signals[2]) { Memory.SIGNAL_CZYT(); } //czyt
            if (signals[3]) { this.SIGNAL_WYAD(); } //wyad
            if (signals[4]) { Counter.SIGNAL_WYL(); } //wyl
            if (signals[5]) { Memory.SIGNAL_WYS(); } //wys
            if (signals[6]) { Accumulator.SIGNAL_WYAK(); } //wyak
            if (signals[7]) { Accumulator.SIGNAL_WEJA(); } //weja
            if (signals[8]) { Accumulator.SIGNAL_PRZEP(); } //przep
            if (signals[9]) { Accumulator.SIGNAL_ODE(); } //ode
            if (signals[10]) { Accumulator.SIGNAL_DOD(); } //dod
            if (signals[11]) { Counter.SIGNAL_WEL(); } //wel
            if (signals[12]) { Memory.SIGNAL_WEA(); } //wea
            if (signals[13]) { Memory.SIGNAL_WES(); } //wes
            if (signals[14]) { Accumulator.SIGNAL_WEAK(); } //weak
            if (signals[15]) { this.SIGNAL_WEI(); } //wei
            if (signals[16]) { Counter.SIGNAL_IL(); } //il

            FinishTick();
        }

        private void SIGNAL_WYAD() //wysylamy na magistrale sam argument
        {
            int argument = CalculateOrderArgumet();
            AddrBus.State = new Bitword(WordLength, argument);
        }

        private void FinishTick()
        {
            AddrBus.Clear();
            DataBus.Clear();
            Accumulator.Clear();
        }

        private void SIGNAL_WEI()
        {
            Content = new Bitword(WordLength, DataBus.State.Get());
        }

        public void SaveOrder(int orderID)
        {
            string filepath = @".\Rozkazy\";
            foreach (var order in orderList)
                if (order.OrderID == orderID)
                {
                    filepath += order.OrderName;
                    filepath += ".r";
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath))
                    {
                        file.WriteLine(order.GetText());
                    }
                    break;
                }
        }

        private void LoadOrders()
        {
            var txtFiles = Directory.EnumerateFiles(@".\Rozkazy", "*.r");
            foreach (string currentFile in txtFiles)
            {
                try
                {
                    string[] lines = File.ReadAllLines(currentFile);
                    string text = string.Join("\n", lines);
                    AddNewOrder(new Order(text));
                }
                catch (Exception) { };
            }
        }

        public void AddNewOrder(Order newOrder)
        {
            orderList.Add(newOrder);
        }

        public void RemoveOrder(int orderID)
        {
            var ordername = orderList.Find(item => item.OrderID == orderID).OrderName;
            orderList.RemoveAll(item => item.OrderID == orderID);
            File.Delete(@".\Rozkazy\" + ordername + ".r");
        }

        internal List<Order> GetOrderList()
        {
            return orderList;
        }
    }

    public class InterpreterState
    {
        public int State;
        public int OrderNumber;
        public int OrderArgument;
    }
}
