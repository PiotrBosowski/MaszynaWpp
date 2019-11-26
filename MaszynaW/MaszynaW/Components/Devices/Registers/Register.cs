using System;
using MaszynaW.Connections.Buses;
using MaszynaW.MaszynaW.Components.Devices;
using MaszynaW.Bitwords;

/* Register allows you to store a value inside
 * in a regular register you cant modify the stored value
 * you can only let new value in or old value out (ofc the value stays inside until you overwrite it with a new value) */

/* Many register-like components will inherit from this class - f.e. counter is a register, that allows you to increment its value */

namespace MaszynaW.Components.Registers
{
    class Register : Device
    {
        private readonly Bus AttachedBus;
        public Register(int wordLength, Bus attachedBus) : base(wordLength)
        {
            content = new Bitword(WordLength);
            AttachedBus = attachedBus;
        }

        public void ReadFromBus()
        {
            Content = AttachedBus.State;
        }

        public void SendToBus()
        {
            AttachedBus.State = Content;
        }
    }
}


//przy wpisywaniu do rejestru nie wystepuje zjawisko konfliktu takie jak na magistrali - rejestr ma tylko jedno wejscie, wiec maksymalnie mamy do czynienia z 1 sygnalem wejsciowym, podczas gdy do magistrali moze byc podpietych bardzo duzo urzadzen