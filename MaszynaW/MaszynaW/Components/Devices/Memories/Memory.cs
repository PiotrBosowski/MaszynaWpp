using MaszynaW.Components.Registers;
using MaszynaW.Connections.Buses;
using MaszynaW.MaszynaW.Components.Devices;
using System;
using MaszynaW.Bitwords;
using System.Collections.Generic;

namespace MaszynaW.Components.Memories
{
    class Memory : Device
    {
        private readonly Bus AddrBus;
        private readonly Bus DataBus;
        private readonly int capacity;
        protected Bitword address;
        public Bitword Address
        {
            get => address;
            set
            {
                address.Set(value);
            }
        }
        protected Bitword data;
        public Bitword Data
        {
            get => data;
            set
            {
                data.Set(value);
            }
        }
        private List<int> MemoryState;
        public List<int> GetMemoryState()
        {
            return MemoryState;
        }

        public Memory(int wordLength, Bus addrBus, Bus dataBus) : base(wordLength)
        {
            address = new Bitword(wordLength);
            data = new Bitword(wordLength);
            AddrBus = addrBus;
            DataBus = dataBus;
            capacity = (int)Math.Pow(2, wordLength);
            MemoryState = new List<int>();
            for (int i = 0; i < capacity; i++)
                MemoryState.Add(new int());
        }

        public void SIGNAL_WEA()
        {
            Address = AddrBus.State;
        }

        public void SIGNAL_CZYT()
        {
            try
            {
                Bitword temp = new Bitword(WordLength, MemoryState[address.Get()]);
                Data = temp;
            }
            catch (Exception)
            {
                Console.WriteLine("Error reading a memory.");
            };
        }

        internal void Format()
        {
            for (int i = 0; i < capacity; i++)
                MemoryState[i] = 0;
            address.Clear();
            data.Clear();
        }

        public void SIGNAL_PISZ()
        {
            try
            {
                Bitword temp = new Bitword(WordLength);
                temp = Data;
                MemoryState[address.Get()] = temp.Get();
            }
            catch (Exception)
            {
                Console.WriteLine("Error writing to a memory.");
            };
        }
        public void SIGNAL_WYS()
        {
            DataBus.State = Data;
        }
        public void SIGNAL_WES()
        {
            Data = DataBus.State;
        }
        
        public void SetAddress()
        {
            Address = AddrBus.State;
        }

        internal void LoadProgram(List<int> tempMemory)
        {
            for (int i = 0; i < tempMemory.Count; ++i)
            {
                int liczba = tempMemory[i];
                MemoryState[i] = liczba;
            }
        }
    }
}
