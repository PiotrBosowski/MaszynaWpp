using System;
using System.Collections.Generic;
using System.IO;

namespace MaszynaW
{
    public class Order
    {
        readonly int orderID;
        public int OrderID { get => orderID; }
        private static int nextOrderID = 1;

        private readonly List<Tick> tickList;
        private string Sourcecode;
        private int numberOfArguments;
        public int NumberOfArguments { get => numberOfArguments; }

        private string orderName;
        public string OrderName { get => orderName; set => orderName = value; }
        internal List<Tick> TickList { get => tickList; }

        public Order(string text)
        {
            orderID = nextOrderID;
            nextOrderID++;
            tickList = new List<Tick>();
            Validate(text);
        }

        public Order()
        {
            orderID = nextOrderID;
            nextOrderID++;
            OrderName = "nowy*";
            tickList = new List<Tick>();
        }

        public void Validate(string text)
        {
            Sourcecode = text.ToLower().Trim();
            if(Sourcecode == "")
            {
                OrderName = "empty " + this.orderID.ToString();
            }
            else try
            {
                string[] lines = Sourcecode.Split(new[] { '\r', '\n' }); //divide into lines
                string[] words = lines[0].Split(null);
                OrderName = words[0];
                numberOfArguments = Int32.Parse(words[1]);
                for (int i = 1; i < lines.Length; i++)
                {
                    TickList.Add(new Tick(lines[i]));
                }
            }
            catch (Exception) { };
        }

        public string GetText()
        {
            return Sourcecode;
        }
    }

    internal class Tick
    {
        bool[] signalsTable;
        public bool[] SignalsTable { get => signalsTable; set => signalsTable = value; }

        public Tick(string line)
        {
            SignalsTable = new bool[17]; //zakladamy ze zeruje sie
            string lineLowercase = line.ToLower();
            string[] words = lineLowercase.Split(null);
            foreach (var word in words)
            {
                switch (word)
                {
                    case "stp": SignalsTable[0] = true; break; //KOLEJNOSC wykonywania SYGNALOW
                    case "pisz": SignalsTable[1] = true; break;
                    case "czyt": SignalsTable[2] = true; break;
                    case "wyad": SignalsTable[3] = true; break;
                    case "wyl": SignalsTable[4] = true; break;
                    case "wys": SignalsTable[5] = true; break;
                    case "wyak": SignalsTable[6] = true; break;
                    case "weja": SignalsTable[7] = true; break;
                    case "przep": SignalsTable[8] = true; break;
                    case "ode": SignalsTable[9] = true; break;
                    case "dod": SignalsTable[10] = true; break;
                    case "wel": SignalsTable[11] = true; break;
                    case "wea": SignalsTable[12] = true; break;
                    case "wes": SignalsTable[13] = true; break;
                    case "weak": SignalsTable[14] = true; break;
                    case "wei": SignalsTable[15] = true; break;
                    case "il": SignalsTable[16] = true; break;
                    default: SignalsTable[0] = true; break;
                }
            }
        }

    }
}