namespace AndroidDataExtractorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage4 = new TabPage();
            dataGridDevice = new DataGridView();
            button12 = new Button();
            button9 = new Button();
            button6 = new Button();
            tabPage3 = new TabPage();
            dataGridCalls = new DataGridView();
            button11 = new Button();
            button8 = new Button();
            button5 = new Button();
            tabPage1 = new TabPage();
            dataGridSMS = new DataGridView();
            button10 = new Button();
            button7 = new Button();
            button4 = new Button();
            tabPage2 = new TabPage();
            dataGridContacts = new DataGridView();
            btnReportContacts = new Button();
            btnSaveContacts = new Button();
            btnLoadContacts = new Button();
            tabControl1 = new TabControl();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDevice).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCalls).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridSMS).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridContacts).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.RosyBrown;
            tabPage4.Controls.Add(dataGridDevice);
            tabPage4.Controls.Add(button12);
            tabPage4.Controls.Add(button9);
            tabPage4.Controls.Add(button6);
            tabPage4.ForeColor = SystemColors.ControlDarkDark;
            tabPage4.Location = new Point(8, 46);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(772, 405);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "Device Info";
            tabPage4.Click += tabPage4_Click;
            // 
            // dataGridDevice
            // 
            dataGridDevice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDevice.Location = new Point(8, 121);
            dataGridDevice.Name = "dataGridDevice";
            dataGridDevice.RowHeadersWidth = 82;
            dataGridDevice.Size = new Size(761, 284);
            dataGridDevice.TabIndex = 5;
            // 
            // button12
            // 
            button12.Location = new Point(575, 48);
            button12.Name = "button12";
            button12.Size = new Size(150, 46);
            button12.TabIndex = 4;
            button12.Text = "View Report";
            button12.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(261, 48);
            button9.Name = "button9";
            button9.Size = new Size(230, 46);
            button9.TabIndex = 3;
            button9.Text = "Save to Database";
            button9.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(45, 48);
            button6.Name = "button6";
            button6.Size = new Size(150, 46);
            button6.TabIndex = 2;
            button6.Text = "Load Data";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.RosyBrown;
            tabPage3.Controls.Add(dataGridCalls);
            tabPage3.Controls.Add(button11);
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(button5);
            tabPage3.ForeColor = SystemColors.ControlDarkDark;
            tabPage3.Location = new Point(8, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(772, 405);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Call Logs";
            // 
            // dataGridCalls
            // 
            dataGridCalls.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCalls.Location = new Point(0, 143);
            dataGridCalls.Name = "dataGridCalls";
            dataGridCalls.RowHeadersWidth = 82;
            dataGridCalls.Size = new Size(772, 262);
            dataGridCalls.TabIndex = 5;
            // 
            // button11
            // 
            button11.Location = new Point(605, 52);
            button11.Name = "button11";
            button11.Size = new Size(150, 46);
            button11.TabIndex = 4;
            button11.Text = "View Report";
            button11.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(311, 52);
            button8.Name = "button8";
            button8.Size = new Size(230, 46);
            button8.TabIndex = 3;
            button8.Text = "Save to Database";
            button8.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(36, 52);
            button5.Name = "button5";
            button5.Size = new Size(150, 46);
            button5.TabIndex = 2;
            button5.Text = "Load Data";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.RosyBrown;
            tabPage1.Controls.Add(dataGridSMS);
            tabPage1.Controls.Add(button10);
            tabPage1.Controls.Add(button7);
            tabPage1.Controls.Add(button4);
            tabPage1.ForeColor = SystemColors.ControlDarkDark;
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(772, 405);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "SMS Messages";
            // 
            // dataGridSMS
            // 
            dataGridSMS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSMS.Location = new Point(8, 129);
            dataGridSMS.Name = "dataGridSMS";
            dataGridSMS.RowHeadersWidth = 82;
            dataGridSMS.Size = new Size(758, 273);
            dataGridSMS.TabIndex = 4;
            // 
            // button10
            // 
            button10.Location = new Point(594, 32);
            button10.Name = "button10";
            button10.Size = new Size(150, 46);
            button10.TabIndex = 3;
            button10.Text = "View Report";
            button10.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(257, 32);
            button7.Name = "button7";
            button7.Size = new Size(230, 46);
            button7.TabIndex = 2;
            button7.Text = "Save to Database";
            button7.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(27, 32);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 1;
            button4.Text = "Load Data";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.RosyBrown;
            tabPage2.Controls.Add(dataGridContacts);
            tabPage2.Controls.Add(btnReportContacts);
            tabPage2.Controls.Add(btnSaveContacts);
            tabPage2.Controls.Add(btnLoadContacts);
            tabPage2.ForeColor = SystemColors.ControlDarkDark;
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(772, 405);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Contacts";
            tabPage2.Click += tabPage2_Click;
            // 
            // dataGridContacts
            // 
            dataGridContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridContacts.Location = new Point(3, 113);
            dataGridContacts.Name = "dataGridContacts";
            dataGridContacts.RowHeadersWidth = 82;
            dataGridContacts.Size = new Size(769, 300);
            dataGridContacts.TabIndex = 3;
            // 
            // btnReportContacts
            // 
            btnReportContacts.Location = new Point(579, 21);
            btnReportContacts.Name = "btnReportContacts";
            btnReportContacts.Size = new Size(150, 46);
            btnReportContacts.TabIndex = 2;
            btnReportContacts.Text = "View Report";
            btnReportContacts.UseVisualStyleBackColor = true;
            // 
            // btnSaveContacts
            // 
            btnSaveContacts.Location = new Point(268, 21);
            btnSaveContacts.Name = "btnSaveContacts";
            btnSaveContacts.Size = new Size(230, 46);
            btnSaveContacts.TabIndex = 1;
            btnSaveContacts.Text = "Save to Database";
            btnSaveContacts.UseVisualStyleBackColor = true;
            // 
            // btnLoadContacts
            // 
            btnLoadContacts.Location = new Point(29, 21);
            btnLoadContacts.Name = "btnLoadContacts";
            btnLoadContacts.Size = new Size(150, 46);
            btnLoadContacts.TabIndex = 0;
            btnLoadContacts.Text = "Load Data";
            btnLoadContacts.UseVisualStyleBackColor = true;
            btnLoadContacts.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(788, 459);
            tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridDevice).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridCalls).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridSMS).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridContacts).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage4;
        private TabPage tabPage3;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnLoadContacts;
        private TabControl tabControl1;
        private Button button4;
        private Button btnReportContacts;
        private Button btnSaveContacts;
        private DataGridView dataGridDevice;
        private Button button12;
        private Button button9;
        private Button button6;
        private DataGridView dataGridCalls;
        private Button button11;
        private Button button8;
        private Button button5;
        private Button button10;
        private Button button7;
        private DataGridView dataGridSMS;
        private DataGridView dataGridContacts;
    }
}
