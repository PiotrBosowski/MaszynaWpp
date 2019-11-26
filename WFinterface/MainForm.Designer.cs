namespace WFinterface
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MaszynaW_PictureBox = new System.Windows.Forms.PictureBox();
            this.Interpreter_TextBox = new System.Windows.Forms.RichTextBox();
            this.Acc_TextBox = new System.Windows.Forms.RichTextBox();
            this.Counter_TextBox = new System.Windows.Forms.RichTextBox();
            this.MemoryData_TextBox = new System.Windows.Forms.RichTextBox();
            this.MemoryAddr_TextBox = new System.Windows.Forms.RichTextBox();
            this.Interpreter_Panel = new System.Windows.Forms.Panel();
            this.InterpreterAs_TextBox = new System.Windows.Forms.RichTextBox();
            this.Counter_Panel = new System.Windows.Forms.Panel();
            this.Acc_Panel = new System.Windows.Forms.Panel();
            this.MemoryAddr_Panel = new System.Windows.Forms.Panel();
            this.Memory_Panel = new System.Windows.Forms.Panel();
            this.Memory_ListBox = new System.Windows.Forms.ListBox();
            this.MemoryData_Panel = new System.Windows.Forms.Panel();
            this.OrderEditor_Panel = new System.Windows.Forms.Panel();
            this.OrderEditor_NowyButton = new System.Windows.Forms.Button();
            this.OrderEditor_WczytajButton = new System.Windows.Forms.Button();
            this.OrderEditor_UsunButton = new System.Windows.Forms.Button();
            this.OrderEditor_ZapiszButton = new System.Windows.Forms.Button();
            this.OrderEditor_LogTextBox = new System.Windows.Forms.RichTextBox();
            this.OrderEditor_OrderList = new System.Windows.Forms.ListBox();
            this.OrderEditor_TextBox = new System.Windows.Forms.RichTextBox();
            this.ProgramEditor_Panel = new System.Windows.Forms.Panel();
            this.ProgramEditor_ZamknijButton = new System.Windows.Forms.Button();
            this.ProgramEditor_WczytajButton = new System.Windows.Forms.Button();
            this.ProgramEditor_ZapiszButton = new System.Windows.Forms.Button();
            this.ProgramEditor_KompilujButton = new System.Windows.Forms.Button();
            this.ProgramEditor_UruchomButton = new System.Windows.Forms.Button();
            this.ProgramEditor_TextBox = new System.Windows.Forms.RichTextBox();
            this.ProgramEditor_LogTextBox = new System.Windows.Forms.RichTextBox();
            this.MaszynaW_Panel = new System.Windows.Forms.Panel();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MaszynaW_PictureBox)).BeginInit();
            this.Interpreter_Panel.SuspendLayout();
            this.Counter_Panel.SuspendLayout();
            this.Acc_Panel.SuspendLayout();
            this.MemoryAddr_Panel.SuspendLayout();
            this.Memory_Panel.SuspendLayout();
            this.MemoryData_Panel.SuspendLayout();
            this.OrderEditor_Panel.SuspendLayout();
            this.ProgramEditor_Panel.SuspendLayout();
            this.MaszynaW_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaszynaW_PictureBox
            // 
            this.MaszynaW_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaszynaW_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MaszynaW_PictureBox.Image")));
            this.MaszynaW_PictureBox.InitialImage = null;
            this.MaszynaW_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.MaszynaW_PictureBox.Name = "MaszynaW_PictureBox";
            this.MaszynaW_PictureBox.Size = new System.Drawing.Size(428, 223);
            this.MaszynaW_PictureBox.TabIndex = 0;
            this.MaszynaW_PictureBox.TabStop = false;
            // 
            // Interpreter_TextBox
            // 
            this.Interpreter_TextBox.BackColor = System.Drawing.Color.White;
            this.Interpreter_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Interpreter_TextBox.Location = new System.Drawing.Point(4, 4);
            this.Interpreter_TextBox.Multiline = false;
            this.Interpreter_TextBox.Name = "Interpreter_TextBox";
            this.Interpreter_TextBox.ReadOnly = true;
            this.Interpreter_TextBox.Size = new System.Drawing.Size(98, 20);
            this.Interpreter_TextBox.TabIndex = 1;
            this.Interpreter_TextBox.Text = "";
            // 
            // Acc_TextBox
            // 
            this.Acc_TextBox.BackColor = System.Drawing.Color.White;
            this.Acc_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Acc_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Acc_TextBox.Location = new System.Drawing.Point(2, 5);
            this.Acc_TextBox.Multiline = false;
            this.Acc_TextBox.Name = "Acc_TextBox";
            this.Acc_TextBox.ReadOnly = true;
            this.Acc_TextBox.Size = new System.Drawing.Size(108, 16);
            this.Acc_TextBox.TabIndex = 3;
            this.Acc_TextBox.Text = "";
            // 
            // Counter_TextBox
            // 
            this.Counter_TextBox.BackColor = System.Drawing.Color.White;
            this.Counter_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Counter_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Counter_TextBox.Location = new System.Drawing.Point(1, 1);
            this.Counter_TextBox.Multiline = false;
            this.Counter_TextBox.Name = "Counter_TextBox";
            this.Counter_TextBox.ReadOnly = true;
            this.Counter_TextBox.Size = new System.Drawing.Size(83, 14);
            this.Counter_TextBox.TabIndex = 4;
            this.Counter_TextBox.Text = "";
            // 
            // MemoryData_TextBox
            // 
            this.MemoryData_TextBox.BackColor = System.Drawing.Color.White;
            this.MemoryData_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MemoryData_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemoryData_TextBox.Location = new System.Drawing.Point(1, 1);
            this.MemoryData_TextBox.Name = "MemoryData_TextBox";
            this.MemoryData_TextBox.ReadOnly = true;
            this.MemoryData_TextBox.Size = new System.Drawing.Size(104, 14);
            this.MemoryData_TextBox.TabIndex = 5;
            this.MemoryData_TextBox.Text = "";
            // 
            // MemoryAddr_TextBox
            // 
            this.MemoryAddr_TextBox.BackColor = System.Drawing.Color.White;
            this.MemoryAddr_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MemoryAddr_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemoryAddr_TextBox.Location = new System.Drawing.Point(1, 1);
            this.MemoryAddr_TextBox.Name = "MemoryAddr_TextBox";
            this.MemoryAddr_TextBox.ReadOnly = true;
            this.MemoryAddr_TextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MemoryAddr_TextBox.Size = new System.Drawing.Size(104, 14);
            this.MemoryAddr_TextBox.TabIndex = 7;
            this.MemoryAddr_TextBox.Text = "";
            // 
            // Interpreter_Panel
            // 
            this.Interpreter_Panel.BackColor = System.Drawing.Color.White;
            this.Interpreter_Panel.Controls.Add(this.InterpreterAs_TextBox);
            this.Interpreter_Panel.Controls.Add(this.Interpreter_TextBox);
            this.Interpreter_Panel.Location = new System.Drawing.Point(5, 30);
            this.Interpreter_Panel.Name = "Interpreter_Panel";
            this.Interpreter_Panel.Padding = new System.Windows.Forms.Padding(4);
            this.Interpreter_Panel.Size = new System.Drawing.Size(106, 43);
            this.Interpreter_Panel.TabIndex = 8;
            // 
            // InterpreterAs_TextBox
            // 
            this.InterpreterAs_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InterpreterAs_TextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InterpreterAs_TextBox.Location = new System.Drawing.Point(4, 23);
            this.InterpreterAs_TextBox.Multiline = false;
            this.InterpreterAs_TextBox.Name = "InterpreterAs_TextBox";
            this.InterpreterAs_TextBox.Size = new System.Drawing.Size(98, 16);
            this.InterpreterAs_TextBox.TabIndex = 16;
            this.InterpreterAs_TextBox.Text = "as:";
            // 
            // Counter_Panel
            // 
            this.Counter_Panel.BackColor = System.Drawing.Color.White;
            this.Counter_Panel.Controls.Add(this.Counter_TextBox);
            this.Counter_Panel.Location = new System.Drawing.Point(165, 41);
            this.Counter_Panel.Name = "Counter_Panel";
            this.Counter_Panel.Padding = new System.Windows.Forms.Padding(1);
            this.Counter_Panel.Size = new System.Drawing.Size(85, 16);
            this.Counter_Panel.TabIndex = 9;
            // 
            // Acc_Panel
            // 
            this.Acc_Panel.BackColor = System.Drawing.Color.White;
            this.Acc_Panel.Controls.Add(this.Acc_TextBox);
            this.Acc_Panel.Location = new System.Drawing.Point(143, 89);
            this.Acc_Panel.Name = "Acc_Panel";
            this.Acc_Panel.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Acc_Panel.Size = new System.Drawing.Size(112, 26);
            this.Acc_Panel.TabIndex = 10;
            // 
            // MemoryAddr_Panel
            // 
            this.MemoryAddr_Panel.BackColor = System.Drawing.Color.White;
            this.MemoryAddr_Panel.Controls.Add(this.MemoryAddr_TextBox);
            this.MemoryAddr_Panel.Location = new System.Drawing.Point(298, 31);
            this.MemoryAddr_Panel.Name = "MemoryAddr_Panel";
            this.MemoryAddr_Panel.Padding = new System.Windows.Forms.Padding(1);
            this.MemoryAddr_Panel.Size = new System.Drawing.Size(106, 16);
            this.MemoryAddr_Panel.TabIndex = 12;
            // 
            // Memory_Panel
            // 
            this.Memory_Panel.BackColor = System.Drawing.Color.White;
            this.Memory_Panel.Controls.Add(this.Memory_ListBox);
            this.Memory_Panel.Location = new System.Drawing.Point(298, 50);
            this.Memory_Panel.Name = "Memory_Panel";
            this.Memory_Panel.Size = new System.Drawing.Size(106, 121);
            this.Memory_Panel.TabIndex = 14;
            // 
            // Memory_ListBox
            // 
            this.Memory_ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Memory_ListBox.FormattingEnabled = true;
            this.Memory_ListBox.Location = new System.Drawing.Point(0, 0);
            this.Memory_ListBox.Margin = new System.Windows.Forms.Padding(0);
            this.Memory_ListBox.Name = "Memory_ListBox";
            this.Memory_ListBox.Size = new System.Drawing.Size(106, 121);
            this.Memory_ListBox.TabIndex = 8;
            // 
            // MemoryData_Panel
            // 
            this.MemoryData_Panel.BackColor = System.Drawing.Color.White;
            this.MemoryData_Panel.Controls.Add(this.MemoryData_TextBox);
            this.MemoryData_Panel.Location = new System.Drawing.Point(298, 174);
            this.MemoryData_Panel.Name = "MemoryData_Panel";
            this.MemoryData_Panel.Padding = new System.Windows.Forms.Padding(1);
            this.MemoryData_Panel.Size = new System.Drawing.Size(106, 16);
            this.MemoryData_Panel.TabIndex = 15;
            // 
            // OrderEditor_Panel
            // 
            this.OrderEditor_Panel.Controls.Add(this.OrderEditor_NowyButton);
            this.OrderEditor_Panel.Controls.Add(this.OrderEditor_WczytajButton);
            this.OrderEditor_Panel.Controls.Add(this.OrderEditor_UsunButton);
            this.OrderEditor_Panel.Controls.Add(this.OrderEditor_ZapiszButton);
            this.OrderEditor_Panel.Controls.Add(this.OrderEditor_LogTextBox);
            this.OrderEditor_Panel.Controls.Add(this.OrderEditor_OrderList);
            this.OrderEditor_Panel.Controls.Add(this.OrderEditor_TextBox);
            this.OrderEditor_Panel.Location = new System.Drawing.Point(12, 241);
            this.OrderEditor_Panel.Name = "OrderEditor_Panel";
            this.OrderEditor_Panel.Size = new System.Drawing.Size(428, 446);
            this.OrderEditor_Panel.TabIndex = 17;
            // 
            // OrderEditor_NowyButton
            // 
            this.OrderEditor_NowyButton.Location = new System.Drawing.Point(62, 0);
            this.OrderEditor_NowyButton.Margin = new System.Windows.Forms.Padding(0);
            this.OrderEditor_NowyButton.Name = "OrderEditor_NowyButton";
            this.OrderEditor_NowyButton.Size = new System.Drawing.Size(61, 23);
            this.OrderEditor_NowyButton.TabIndex = 7;
            this.OrderEditor_NowyButton.Text = "Nowy";
            this.OrderEditor_NowyButton.UseVisualStyleBackColor = true;
            this.OrderEditor_NowyButton.Click += new System.EventHandler(this.OrderEditor_NowyButton_Click);
            // 
            // OrderEditor_WczytajButton
            // 
            this.OrderEditor_WczytajButton.Location = new System.Drawing.Point(184, 0);
            this.OrderEditor_WczytajButton.Margin = new System.Windows.Forms.Padding(0);
            this.OrderEditor_WczytajButton.Name = "OrderEditor_WczytajButton";
            this.OrderEditor_WczytajButton.Size = new System.Drawing.Size(61, 23);
            this.OrderEditor_WczytajButton.TabIndex = 6;
            this.OrderEditor_WczytajButton.Text = "Wczytaj";
            this.OrderEditor_WczytajButton.UseVisualStyleBackColor = true;
            this.OrderEditor_WczytajButton.Click += new System.EventHandler(this.OrderEditor_WczytajButton_Click);
            // 
            // OrderEditor_UsunButton
            // 
            this.OrderEditor_UsunButton.Location = new System.Drawing.Point(383, 0);
            this.OrderEditor_UsunButton.Name = "OrderEditor_UsunButton";
            this.OrderEditor_UsunButton.Size = new System.Drawing.Size(45, 23);
            this.OrderEditor_UsunButton.TabIndex = 5;
            this.OrderEditor_UsunButton.Text = "Usun";
            this.OrderEditor_UsunButton.UseVisualStyleBackColor = true;
            this.OrderEditor_UsunButton.Click += new System.EventHandler(this.OrderEditor_UsunButton_Click);
            // 
            // OrderEditor_ZapiszButton
            // 
            this.OrderEditor_ZapiszButton.Location = new System.Drawing.Point(123, 0);
            this.OrderEditor_ZapiszButton.Margin = new System.Windows.Forms.Padding(0);
            this.OrderEditor_ZapiszButton.Name = "OrderEditor_ZapiszButton";
            this.OrderEditor_ZapiszButton.Size = new System.Drawing.Size(61, 23);
            this.OrderEditor_ZapiszButton.TabIndex = 4;
            this.OrderEditor_ZapiszButton.Text = "Zapisz";
            this.OrderEditor_ZapiszButton.UseVisualStyleBackColor = true;
            this.OrderEditor_ZapiszButton.Click += new System.EventHandler(this.OrderEditor_ZapiszButton_Click);
            // 
            // OrderEditor_LogTextBox
            // 
            this.OrderEditor_LogTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.OrderEditor_LogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderEditor_LogTextBox.Location = new System.Drawing.Point(62, 429);
            this.OrderEditor_LogTextBox.Name = "OrderEditor_LogTextBox";
            this.OrderEditor_LogTextBox.Size = new System.Drawing.Size(366, 17);
            this.OrderEditor_LogTextBox.TabIndex = 2;
            this.OrderEditor_LogTextBox.Text = "logi z edytora rozkazow";
            // 
            // OrderEditor_OrderList
            // 
            this.OrderEditor_OrderList.FormattingEnabled = true;
            this.OrderEditor_OrderList.Location = new System.Drawing.Point(0, 0);
            this.OrderEditor_OrderList.Name = "OrderEditor_OrderList";
            this.OrderEditor_OrderList.Size = new System.Drawing.Size(56, 446);
            this.OrderEditor_OrderList.TabIndex = 1;
            this.OrderEditor_OrderList.SelectedIndexChanged += new System.EventHandler(this.OrderEditor_OrderList_SelectedIndexChanged);
            // 
            // OrderEditor_TextBox
            // 
            this.OrderEditor_TextBox.Location = new System.Drawing.Point(62, 25);
            this.OrderEditor_TextBox.Name = "OrderEditor_TextBox";
            this.OrderEditor_TextBox.Size = new System.Drawing.Size(366, 398);
            this.OrderEditor_TextBox.TabIndex = 0;
            this.OrderEditor_TextBox.Text = "";
            // 
            // ProgramEditor_Panel
            // 
            this.ProgramEditor_Panel.Controls.Add(this.ProgramEditor_ZamknijButton);
            this.ProgramEditor_Panel.Controls.Add(this.ProgramEditor_WczytajButton);
            this.ProgramEditor_Panel.Controls.Add(this.ProgramEditor_ZapiszButton);
            this.ProgramEditor_Panel.Controls.Add(this.ProgramEditor_KompilujButton);
            this.ProgramEditor_Panel.Controls.Add(this.ProgramEditor_UruchomButton);
            this.ProgramEditor_Panel.Controls.Add(this.ProgramEditor_TextBox);
            this.ProgramEditor_Panel.Location = new System.Drawing.Point(446, 11);
            this.ProgramEditor_Panel.Name = "ProgramEditor_Panel";
            this.ProgramEditor_Panel.Size = new System.Drawing.Size(419, 676);
            this.ProgramEditor_Panel.TabIndex = 18;
            // 
            // ProgramEditor_ZamknijButton
            // 
            this.ProgramEditor_ZamknijButton.Location = new System.Drawing.Point(360, 0);
            this.ProgramEditor_ZamknijButton.Margin = new System.Windows.Forms.Padding(0);
            this.ProgramEditor_ZamknijButton.Name = "ProgramEditor_ZamknijButton";
            this.ProgramEditor_ZamknijButton.Size = new System.Drawing.Size(59, 23);
            this.ProgramEditor_ZamknijButton.TabIndex = 6;
            this.ProgramEditor_ZamknijButton.Text = "Zamknij";
            this.ProgramEditor_ZamknijButton.UseVisualStyleBackColor = true;
            this.ProgramEditor_ZamknijButton.Click += new System.EventHandler(this.ProgramEditor_ZamknijButton_Click);
            // 
            // ProgramEditor_WczytajButton
            // 
            this.ProgramEditor_WczytajButton.Location = new System.Drawing.Point(183, 0);
            this.ProgramEditor_WczytajButton.Margin = new System.Windows.Forms.Padding(0);
            this.ProgramEditor_WczytajButton.Name = "ProgramEditor_WczytajButton";
            this.ProgramEditor_WczytajButton.Size = new System.Drawing.Size(61, 23);
            this.ProgramEditor_WczytajButton.TabIndex = 5;
            this.ProgramEditor_WczytajButton.Text = "Wczytaj";
            this.ProgramEditor_WczytajButton.UseVisualStyleBackColor = true;
            this.ProgramEditor_WczytajButton.Click += new System.EventHandler(this.ProgramEditor_WczytajButton_Click);
            // 
            // ProgramEditor_ZapiszButton
            // 
            this.ProgramEditor_ZapiszButton.Location = new System.Drawing.Point(122, 0);
            this.ProgramEditor_ZapiszButton.Margin = new System.Windows.Forms.Padding(0);
            this.ProgramEditor_ZapiszButton.Name = "ProgramEditor_ZapiszButton";
            this.ProgramEditor_ZapiszButton.Size = new System.Drawing.Size(61, 23);
            this.ProgramEditor_ZapiszButton.TabIndex = 4;
            this.ProgramEditor_ZapiszButton.Text = "Zapisz";
            this.ProgramEditor_ZapiszButton.UseVisualStyleBackColor = true;
            this.ProgramEditor_ZapiszButton.Click += new System.EventHandler(this.ProgramEditor_ZapiszButton_Click);
            // 
            // ProgramEditor_KompilujButton
            // 
            this.ProgramEditor_KompilujButton.Location = new System.Drawing.Point(61, 0);
            this.ProgramEditor_KompilujButton.Margin = new System.Windows.Forms.Padding(0);
            this.ProgramEditor_KompilujButton.Name = "ProgramEditor_KompilujButton";
            this.ProgramEditor_KompilujButton.Size = new System.Drawing.Size(61, 23);
            this.ProgramEditor_KompilujButton.TabIndex = 3;
            this.ProgramEditor_KompilujButton.Text = "Kompiluj";
            this.ProgramEditor_KompilujButton.UseVisualStyleBackColor = true;
            this.ProgramEditor_KompilujButton.Click += new System.EventHandler(this.ProgramEditor_KompilujButton_Click);
            // 
            // ProgramEditor_UruchomButton
            // 
            this.ProgramEditor_UruchomButton.Location = new System.Drawing.Point(0, 0);
            this.ProgramEditor_UruchomButton.Margin = new System.Windows.Forms.Padding(0);
            this.ProgramEditor_UruchomButton.Name = "ProgramEditor_UruchomButton";
            this.ProgramEditor_UruchomButton.Size = new System.Drawing.Size(61, 23);
            this.ProgramEditor_UruchomButton.TabIndex = 2;
            this.ProgramEditor_UruchomButton.Text = "Uruchom";
            this.ProgramEditor_UruchomButton.UseVisualStyleBackColor = true;
            this.ProgramEditor_UruchomButton.Click += new System.EventHandler(this.ProgramEditor_UruchomButton_Click);
            // 
            // ProgramEditor_TextBox
            // 
            this.ProgramEditor_TextBox.Location = new System.Drawing.Point(0, 25);
            this.ProgramEditor_TextBox.Name = "ProgramEditor_TextBox";
            this.ProgramEditor_TextBox.Size = new System.Drawing.Size(419, 628);
            this.ProgramEditor_TextBox.TabIndex = 0;
            this.ProgramEditor_TextBox.Text = "";
            // 
            // ProgramEditor_LogTextBox
            // 
            this.ProgramEditor_LogTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ProgramEditor_LogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProgramEditor_LogTextBox.Location = new System.Drawing.Point(446, 670);
            this.ProgramEditor_LogTextBox.Name = "ProgramEditor_LogTextBox";
            this.ProgramEditor_LogTextBox.Size = new System.Drawing.Size(419, 17);
            this.ProgramEditor_LogTextBox.TabIndex = 1;
            this.ProgramEditor_LogTextBox.Text = "Logi z edytora programu zaawansowanego IDE maszyny W";
            // 
            // MaszynaW_Panel
            // 
            this.MaszynaW_Panel.Controls.Add(this.MemoryAddr_Panel);
            this.MaszynaW_Panel.Controls.Add(this.Counter_Panel);
            this.MaszynaW_Panel.Controls.Add(this.MemoryData_Panel);
            this.MaszynaW_Panel.Controls.Add(this.Interpreter_Panel);
            this.MaszynaW_Panel.Controls.Add(this.Memory_Panel);
            this.MaszynaW_Panel.Controls.Add(this.Acc_Panel);
            this.MaszynaW_Panel.Controls.Add(this.MaszynaW_PictureBox);
            this.MaszynaW_Panel.Location = new System.Drawing.Point(12, 12);
            this.MaszynaW_Panel.Name = "MaszynaW_Panel";
            this.MaszynaW_Panel.Size = new System.Drawing.Size(428, 223);
            this.MaszynaW_Panel.TabIndex = 0;
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 20;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(875, 698);
            this.Controls.Add(this.OrderEditor_Panel);
            this.Controls.Add(this.MaszynaW_Panel);
            this.Controls.Add(this.ProgramEditor_LogTextBox);
            this.Controls.Add(this.ProgramEditor_Panel);
            this.Name = "MainForm";
            this.Text = "maszynaW";
            ((System.ComponentModel.ISupportInitialize)(this.MaszynaW_PictureBox)).EndInit();
            this.Interpreter_Panel.ResumeLayout(false);
            this.Counter_Panel.ResumeLayout(false);
            this.Acc_Panel.ResumeLayout(false);
            this.MemoryAddr_Panel.ResumeLayout(false);
            this.Memory_Panel.ResumeLayout(false);
            this.MemoryData_Panel.ResumeLayout(false);
            this.OrderEditor_Panel.ResumeLayout(false);
            this.ProgramEditor_Panel.ResumeLayout(false);
            this.MaszynaW_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MaszynaW_PictureBox;
        private System.Windows.Forms.RichTextBox Interpreter_TextBox;
        private System.Windows.Forms.RichTextBox Acc_TextBox;
        private System.Windows.Forms.RichTextBox Counter_TextBox;
        private System.Windows.Forms.RichTextBox MemoryData_TextBox;
        private System.Windows.Forms.RichTextBox MemoryAddr_TextBox;
        private System.Windows.Forms.Panel Interpreter_Panel;
        private System.Windows.Forms.Panel Counter_Panel;
        private System.Windows.Forms.Panel Acc_Panel;
        private System.Windows.Forms.Panel MemoryAddr_Panel;
        private System.Windows.Forms.Panel Memory_Panel;
        private System.Windows.Forms.Panel MemoryData_Panel;
        private System.Windows.Forms.RichTextBox InterpreterAs_TextBox;
        private System.Windows.Forms.Panel OrderEditor_Panel;
        private System.Windows.Forms.Panel ProgramEditor_Panel;
        private System.Windows.Forms.Panel MaszynaW_Panel;
        private System.Windows.Forms.RichTextBox OrderEditor_TextBox;
        private System.Windows.Forms.RichTextBox ProgramEditor_TextBox;
        private System.Windows.Forms.ListBox OrderEditor_OrderList;
        private System.Windows.Forms.RichTextBox OrderEditor_LogTextBox;
        private System.Windows.Forms.RichTextBox ProgramEditor_LogTextBox;
        private System.Windows.Forms.Button OrderEditor_UsunButton;
        private System.Windows.Forms.Button OrderEditor_ZapiszButton;
        private System.Windows.Forms.Button ProgramEditor_WczytajButton;
        private System.Windows.Forms.Button ProgramEditor_ZapiszButton;
        private System.Windows.Forms.Button ProgramEditor_KompilujButton;
        private System.Windows.Forms.Button ProgramEditor_UruchomButton;
        private System.Windows.Forms.Button OrderEditor_WczytajButton;
        private System.Windows.Forms.Button ProgramEditor_ZamknijButton;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.ListBox Memory_ListBox;
        private System.Windows.Forms.Button OrderEditor_NowyButton;
    }
}

