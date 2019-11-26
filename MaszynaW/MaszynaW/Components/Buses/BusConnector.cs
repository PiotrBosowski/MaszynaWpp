using MaszynaW.Components;
using MaszynaW.Connections.Buses;
using System;

namespace MaszynaW.MaszynaW.Components.Buses
{
    class BusConnector : Component
    {
        //"Behave as AS bus"
        Bus A;
        Bus S;

        public BusConnector(int wordLength, Bus A_, Bus S_) : base(wordLength)
        {
            A = A_;
            S = S_;
        }

        public void ConnectBuses() //called AFTER all signals are emited on buses
        {
            //It physically connects the buses - if the BusConflict occures, it is handled
            if(A.AlreadyInUse && !S.AlreadyInUse) // A used, S unused: A->S
            {
                S.State = A.State;
            }
            else if (!A.AlreadyInUse && S.AlreadyInUse) // A unused, S used: S->A
            {
                S.State = A.State;
            }
            else if (A.AlreadyInUse && S.AlreadyInUse) //BUS CONFLICT
            {
                A.State = S.State;
                S.State = A.State; //no need to save A's state before overwriting, should work like this
            }
            else if(!A.AlreadyInUse && !S.AlreadyInUse) //BUSES UNUSED
            {
                return;
            }
        }
    }
}
