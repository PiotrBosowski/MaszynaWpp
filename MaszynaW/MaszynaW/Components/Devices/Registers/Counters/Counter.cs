using System;
using MaszynaW.Components.Registers;
using MaszynaW.Connections.Buses;

namespace MaszynaW.Components.Registers.Counters
{
    class Counter : Register
    {
        public Counter(int wordLength, Bus attachedBus) : base(wordLength, attachedBus)
        {
        }

        public void SIGNAL_WYL()
        {
            SendToBus();
        }

        public void SIGNAL_WEL()
        {
            ReadFromBus();
        }

        public int GetState()
        {
            return content.Get();
        }

        internal void SIGNAL_IL()
        {
            Content++;
        }

        internal void Clear()
        {
            content.Clear();
        }
    }
}