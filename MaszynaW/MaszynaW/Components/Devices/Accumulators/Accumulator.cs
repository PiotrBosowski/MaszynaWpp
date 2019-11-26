using MaszynaW.Bitwords;
using MaszynaW.Components.Registers;
using MaszynaW.Connections.Buses;
using MaszynaW.MaszynaW.Components.Devices;
using System;

namespace MaszynaW.Components.Accumulators
{
    class Accumulator : Device
    {
        public Accumulator(int wordLength, Bus dataBus) : base(wordLength)
        {
            temp = new Bitword(WordLength);
            DataBus = dataBus;
        }

        private readonly Bus DataBus;
        private Bitword temp; //pomocniczy rejestr akumulatora, niewidoczny nawet na schemacie xd
        private Bitword Temp
        {
            get => temp;
            set => temp = value;
        }

        public void Clear()
        {
            Temp.Clear();
        }

        internal void SIGNAL_WEAK()
        {
           Content = new Bitword(WordLength, Temp.Get());
        }

        internal void SIGNAL_DOD()
        {
            Temp = new Bitword(WordLength, Content.Get() + Temp.Get());
        }

        internal void SIGNAL_ODE()
        {
            Temp = new Bitword(WordLength, Content.Get() - Temp.Get());
        }

        internal void SIGNAL_PRZEP()
        {
            return;
        }

        internal void SIGNAL_WEJA()
        {
            Temp = DataBus.State;
        }

        internal void SIGNAL_WYAK()
        {
            DataBus.State = Content;
        }

        internal void HardClear()
        {
            temp = new Bitword(WordLength);
            content = new Bitword(WordLength);
        }
    }
}