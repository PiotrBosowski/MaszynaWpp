using MaszynaW.Components;
using MaszynaW.Bitwords;
using System;

namespace MaszynaW.Connections.Buses
{
    public class Bus : Component
    {
        //its possible to refactor this class so it doesnt need alreadyInUse field anymore - state should be null by default (that means no conflict occured)
        public Bus(int wordLength) : base(wordLength)
        {
            state = new Bitword(WordLength);
            alreadyInUse = false;
        }

        private bool alreadyInUse; //variable informs, if more than one device is trying to send something to the bus - if yes, we have to handle bus conflict
        public bool AlreadyInUse { get => alreadyInUse; }

        private Bitword state;
        public Bitword State
        {
            get => state;
            set
            {
                if (alreadyInUse)
                {
                    //BUS CONFLICT
                    state.Set(Bitword.ResolveConflict(state, value));
                    //WARGING LOG: BUS_CONFLICT
                }
                else
                {
                    state.Set(value);
                    alreadyInUse = true;
                }
            }
        }

        public void Clear()
        {
            state.Clear();
            alreadyInUse = false;
        }
    }
}

//w przypadku konfliktu na magistrali nastepuje sciaganie zerem (na kazdym bicie slowa wykonujemy AND - tylko 2,3,4,... jedynek da 1, wystarczy jedno 0 i wartosc bitu to 0)
//jezeli 1 urzadzenie zacznie nadawac sygnal 00001111 a drugie 01010101 - dostaniemy na magistrali 00000101; jesli do tego trzecie urzadzenie zacznie nadawac sygnal 11111110 - dostaniemy na magistrali 00000100;
//maszyna W nie powinna zglaszac w takim wypadku bledu - bo niby jak mialaby to rozpoznac? bez sensu
