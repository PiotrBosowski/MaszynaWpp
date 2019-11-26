using MaszynaW.Components.Accumulators;
using MaszynaW.Components.Registers.Counters;
using MaszynaW.Connections.Buses;
using MaszynaW.Components.Memories;
using System;
using MaszynaW.MaszynaW.Components.Buses;
using System.Collections.Generic;
using MaszynaW.MaszynaW.Components.Devices;
using MaszynaW.MaszynaW;

namespace MaszynaW
{
    public class Machine : IPublic
    {
        private readonly int WordLength;
        private readonly int AddrLength;
        private readonly int DataLength;
        private readonly Accumulator Accumulator;
        private readonly Counter Counter;
        private readonly Memory Memory;
        private readonly Bus AddrBus;


        private readonly Bus DataBus;
        private readonly BusConnector ADBus;
        private readonly Interpreter Interpreter;

        public Machine(short WordLength, short AddrLength)
        {
            this.WordLength = WordLength;
            this.AddrLength = WordLength;
            this.DataLength = WordLength - AddrLength;

            //creating buses...
            AddrBus = new Bus(WordLength);
            DataBus = new Bus(WordLength);

            //connecting buses...
            ADBus = new BusConnector(WordLength, AddrBus, DataBus);

            //creating components...
            Memory = new Memory(WordLength, AddrBus, DataBus);
            Counter = new Counter(WordLength, AddrBus);
            Accumulator = new Accumulator(WordLength, DataBus);
            Interpreter = new Interpreter(WordLength, AddrLength, this, AddrBus, DataBus, Memory, Counter, Accumulator);
        }

        public void SaveOrder(int orderID)
        {
            Interpreter.SaveOrder(orderID);         
        }

        public void RunProgram()
        {
            Interpreter.RunProgram();
        }

        public void CompileProgram(string sourcecode)
        {
            Interpreter.CompileProgram(sourcecode);
        }

        public void AddNewOrder(Order NewOrder)
        {
            Interpreter.AddNewOrder(NewOrder);
        }

        public void RemoveOrder(int OrderID)
        {
            Interpreter.RemoveOrder(OrderID);
        }

        public MachineState GetMachineState()
        {
            MachineState temp = new MachineState
            {
                InterpreterState = Interpreter.GetState(),
                CounterState = Counter.GetState(),
                MemoryAddrState = Memory.Address.Get(),
                MemoryDataState = Memory.Data.Get(),
                AccState = Accumulator.Content.Get(),
            };
            return temp;
        }

        public List<Order> GetOrderList()
        {
            return Interpreter.GetOrderList();
        }


        public List<int> GetMemoryState()
        {
            return Memory.GetMemoryState();
        }
    }

    public class MachineState
    {
        public InterpreterState InterpreterState;
        public int CounterState;
        public int MemoryAddrState;
        public int MemoryDataState;
        public int AccState;
    }
}

