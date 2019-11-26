using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MaszynaW;

namespace WFinterface
{
    public partial class MainForm : Form
    {
        private Machine machine;
        private MachineState state;
        private List<int> memoryState;
        private List<Order> OrderList;
        private int nazwaZmiennej;
        public int NazwaZmiennej { set => nazwaZmiennej = value; }

        public MainForm(Machine machine)
        {
            this.machine = machine;
            OrderList = machine.GetOrderList();
            memoryState = machine.GetMemoryState();
            InitializeComponent();
            UpdateMemory();
            UpdateOrderList();
        }

        private void UpdateMemory()
        {
            Memory_ListBox.DataSource = null;
            Memory_ListBox.DataSource = memoryState;
        }

        private void UpdateOrderList()
        {
            OrderEditor_OrderList.DataSource = null;
            OrderEditor_OrderList.DataSource = OrderList;
            OrderEditor_OrderList.DisplayMember = "OrderName";
        }

        private void UpdateOrderTextBox()
        {
            int index = OrderEditor_OrderList.SelectedIndex;
            string sourcecode;
            if (index > -1)
            {
                sourcecode = machine.GetOrderList()[index].GetText();
            }
            else
                sourcecode = "";
            OrderEditor_TextBox.Text = sourcecode;
        }

        private void UpdateState()
        {
            state = machine.GetMachineState();
            Interpreter_TextBox.Text = state.InterpreterState.State.ToString();
            InterpreterAs_TextBox.Text = state.InterpreterState.OrderNumber.ToString() + " | " + state.InterpreterState.OrderArgument.ToString();
            Acc_TextBox.Text = state.AccState.ToString();
            Counter_TextBox.Text = state.CounterState.ToString();
            MemoryAddr_TextBox.Text = state.MemoryAddrState.ToString();
            MemoryData_TextBox.Text = state.MemoryDataState.ToString();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void OrderEditor_OrderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOrderTextBox();
        }

        private void OrderEditor_NowyButton_Click(object sender, EventArgs e)
        {
            Order temp = new Order();
            machine.AddNewOrder(temp);
            UpdateOrderList();
        }

        private void OrderEditor_ZapiszButton_Click(object sender, EventArgs e)
        {
            int index = OrderEditor_OrderList.SelectedIndex;
            if (index == -1) return;
            machine.GetOrderList()[index].Validate(OrderEditor_TextBox.Text);
            int orderID = machine.GetOrderList()[index].OrderID;
            machine.SaveOrder(orderID);
            UpdateOrderList();
        }

        private void OrderEditor_UsunButton_Click(object sender, EventArgs e)
        {
            int index = OrderEditor_OrderList.SelectedIndex;
            if (index == -1) return;
            int orderID = machine.GetOrderList()[index].OrderID;
            machine.RemoveOrder(orderID);
            OrderEditor_OrderList.Update();
            UpdateOrderList();
        }

        private void OrderEditor_WczytajButton_Click(object sender, EventArgs e)
        {
            try
            {
                string text = ReadTextFromFile();
                OrderEditor_TextBox.Text = text;
            }
            catch (Exception) { };
        }

        private void ProgramEditor_WczytajButton_Click(object sender, EventArgs e)
        {
            try
            {
                string text = ReadTextFromFile();
                ProgramEditor_TextBox.Text = text;
                ProgramEditor_TextBox.Update();
            }
            catch (Exception) { };
        }

        private string ReadTextFromFile() //throws Exception() if unsuccsessful
        {
            OpenFileDialog filed = new OpenFileDialog();
            string text = "";
            if (filed.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filepath = filed.FileName; // prints path
                    string[] lines = File.ReadAllLines(filepath);
                    text = string.Join("\n", lines);
                }
                catch (Exception) {}
            }
            return text;
        }

        private void ProgramEditor_ZapiszButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog filed = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = "W"
            };
            if (filed.ShowDialog() == DialogResult.OK)
            {
                string filepath = filed.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath))
                {
                     file.WriteLine(ProgramEditor_TextBox.Text);
                }
            }
        }

        private void ProgramEditor_ZamknijButton_Click(object sender, EventArgs e)
        {
            ProgramEditor_TextBox.Text = "";
            ProgramEditor_TextBox.Update();
        }

        private void ProgramEditor_KompilujButton_Click(object sender, EventArgs e)
        {
            machine.CompileProgram(ProgramEditor_TextBox.Text);
            UpdateMemory();
        }

        private void ProgramEditor_UruchomButton_Click(object sender, EventArgs e)
        {
            machine.RunProgram();
        }
    }
}