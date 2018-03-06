namespace ModbusRtuTestApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Com_List = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Open_Or_Close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Action_List = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Count_Number_UpDowm = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Address_Number_UpDowm = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Device_Number_UpDowm = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Checked_Cmd_Text = new System.Windows.Forms.TextBox();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.Result_Text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.BaudRate_List = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Count_Number_UpDowm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Address_Number_UpDowm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Device_Number_UpDowm)).BeginInit();
            this.SuspendLayout();
            // 
            // Com_List
            // 
            this.Com_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Com_List.FormattingEnabled = true;
            this.Com_List.Location = new System.Drawing.Point(47, 9);
            this.Com_List.Name = "Com_List";
            this.Com_List.Size = new System.Drawing.Size(121, 20);
            this.Com_List.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "串口";
            // 
            // Btn_Open_Or_Close
            // 
            this.Btn_Open_Or_Close.Location = new System.Drawing.Point(377, 7);
            this.Btn_Open_Or_Close.Name = "Btn_Open_Or_Close";
            this.Btn_Open_Or_Close.Size = new System.Drawing.Size(75, 23);
            this.Btn_Open_Or_Close.TabIndex = 2;
            this.Btn_Open_Or_Close.Text = "打开";
            this.Btn_Open_Or_Close.UseVisualStyleBackColor = true;
            this.Btn_Open_Or_Close.Click += new System.EventHandler(this.Btn_Open_Or_Close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "操作";
            // 
            // Action_List
            // 
            this.Action_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Action_List.FormattingEnabled = true;
            this.Action_List.Items.AddRange(new object[] {
            "读取"});
            this.Action_List.Location = new System.Drawing.Point(138, 36);
            this.Action_List.Name = "Action_List";
            this.Action_List.Size = new System.Drawing.Size(71, 20);
            this.Action_List.TabIndex = 0;
            this.Action_List.SelectedIndexChanged += new System.EventHandler(this.Action_List_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Count_Number_UpDowm);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Address_Number_UpDowm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Device_Number_UpDowm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Action_List);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modbus Rtu 命令";
            // 
            // Count_Number_UpDowm
            // 
            this.Count_Number_UpDowm.Location = new System.Drawing.Point(429, 37);
            this.Count_Number_UpDowm.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Count_Number_UpDowm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Count_Number_UpDowm.Name = "Count_Number_UpDowm";
            this.Count_Number_UpDowm.Size = new System.Drawing.Size(66, 21);
            this.Count_Number_UpDowm.TabIndex = 3;
            this.Count_Number_UpDowm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Count_Number_UpDowm.ValueChanged += new System.EventHandler(this.Value_Changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "数据个数";
            // 
            // Address_Number_UpDowm
            // 
            this.Address_Number_UpDowm.Location = new System.Drawing.Point(288, 37);
            this.Address_Number_UpDowm.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Address_Number_UpDowm.Name = "Address_Number_UpDowm";
            this.Address_Number_UpDowm.Size = new System.Drawing.Size(66, 21);
            this.Address_Number_UpDowm.TabIndex = 3;
            this.Address_Number_UpDowm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Address_Number_UpDowm.ValueChanged += new System.EventHandler(this.Value_Changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "起始地址";
            // 
            // Device_Number_UpDowm
            // 
            this.Device_Number_UpDowm.Location = new System.Drawing.Point(40, 36);
            this.Device_Number_UpDowm.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.Device_Number_UpDowm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Device_Number_UpDowm.Name = "Device_Number_UpDowm";
            this.Device_Number_UpDowm.Size = new System.Drawing.Size(46, 21);
            this.Device_Number_UpDowm.TabIndex = 3;
            this.Device_Number_UpDowm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Device_Number_UpDowm.ValueChanged += new System.EventHandler(this.Value_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "站号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "添加校验后的命令";
            // 
            // Checked_Cmd_Text
            // 
            this.Checked_Cmd_Text.Location = new System.Drawing.Point(119, 145);
            this.Checked_Cmd_Text.Name = "Checked_Cmd_Text";
            this.Checked_Cmd_Text.Size = new System.Drawing.Size(292, 21);
            this.Checked_Cmd_Text.TabIndex = 5;
            // 
            // Btn_Send
            // 
            this.Btn_Send.Enabled = false;
            this.Btn_Send.Location = new System.Drawing.Point(417, 144);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(100, 23);
            this.Btn_Send.TabIndex = 6;
            this.Btn_Send.Text = "发送到串口";
            this.Btn_Send.UseVisualStyleBackColor = true;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // Result_Text
            // 
            this.Result_Text.Location = new System.Drawing.Point(12, 200);
            this.Result_Text.Multiline = true;
            this.Result_Text.Name = "Result_Text";
            this.Result_Text.ReadOnly = true;
            this.Result_Text.Size = new System.Drawing.Size(505, 71);
            this.Result_Text.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "返回结果如下";
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // BaudRate_List
            // 
            this.BaudRate_List.FormattingEnabled = true;
            this.BaudRate_List.Items.AddRange(new object[] {
            "9600"});
            this.BaudRate_List.Location = new System.Drawing.Point(236, 9);
            this.BaudRate_List.Name = "BaudRate_List";
            this.BaudRate_List.Size = new System.Drawing.Size(121, 20);
            this.BaudRate_List.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "波特率";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 283);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Result_Text);
            this.Controls.Add(this.Btn_Send);
            this.Controls.Add(this.Checked_Cmd_Text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Open_Or_Close);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BaudRate_List);
            this.Controls.Add(this.Com_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "ModbusRtu检测程序";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Count_Number_UpDowm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Address_Number_UpDowm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Device_Number_UpDowm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Com_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Open_Or_Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Action_List;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown Count_Number_UpDowm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Address_Number_UpDowm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Device_Number_UpDowm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Checked_Cmd_Text;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.TextBox Result_Text;
        private System.Windows.Forms.Label label7;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox BaudRate_List;
        private System.Windows.Forms.Label label8;
    }
}

