using System.Collections.Generic;

namespace MaszynaW.MaszynaW
{
    interface IPublic
    {
        void RunProgram(); //starts current program
        void CompileProgram(string sourcecode); //compiles program
        void AddNewOrder(Order NewOrder); //adds new order
        void RemoveOrder(int OrderID); //removes order
        void SaveOrder(int orderID);
        MachineState GetMachineState();
        List<Order> GetOrderList();
    }
}
