namespace KeyenceSensorTest
{
    partial class SensorTest_form
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Port_Select = new System.Windows.Forms.ComboBox();
            this.Select_Port_Label = new System.Windows.Forms.Label();
            this.Communication_Button = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.TextBox();
            this.Select_Communication_Command = new System.Windows.Forms.ComboBox();
            this.Selct_communication_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.Select_IDnumber = new System.Windows.Forms.ComboBox();
            this.Data_Label = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.result_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Port_Select
            // 
            this.Port_Select.FormattingEnabled = true;
            this.Port_Select.Location = new System.Drawing.Point(85, 41);
            this.Port_Select.Name = "Port_Select";
            this.Port_Select.Size = new System.Drawing.Size(121, 20);
            this.Port_Select.TabIndex = 0;
            // 
            // Select_Port_Label
            // 
            this.Select_Port_Label.AutoSize = true;
            this.Select_Port_Label.Location = new System.Drawing.Point(19, 44);
            this.Select_Port_Label.Name = "Select_Port_Label";
            this.Select_Port_Label.Size = new System.Drawing.Size(60, 12);
            this.Select_Port_Label.TabIndex = 1;
            this.Select_Port_Label.Text = "COM番号：";
            // 
            // Communication_Button
            // 
            this.Communication_Button.Location = new System.Drawing.Point(274, 39);
            this.Communication_Button.Name = "Communication_Button";
            this.Communication_Button.Size = new System.Drawing.Size(75, 23);
            this.Communication_Button.TabIndex = 2;
            this.Communication_Button.Text = "送信";
            this.Communication_Button.UseVisualStyleBackColor = true;
            this.Communication_Button.Click += new System.EventHandler(this.Communication_Click);
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(259, 108);
            this.value.Multiline = true;
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(113, 22);
            this.value.TabIndex = 3;
            // 
            // Select_Communication_Command
            // 
            this.Select_Communication_Command.FormattingEnabled = true;
            this.Select_Communication_Command.Items.AddRange(new object[] {
            "SR",
            "M0",
            "MS",
            "DR",
            "SW",
            "AW"});
            this.Select_Communication_Command.Location = new System.Drawing.Point(21, 108);
            this.Select_Communication_Command.Name = "Select_Communication_Command";
            this.Select_Communication_Command.Size = new System.Drawing.Size(81, 20);
            this.Select_Communication_Command.TabIndex = 4;
            this.Select_Communication_Command.SelectedIndexChanged += new System.EventHandler(this.Select_Communication_Command_SelectedIndexChanged);
            // 
            // Selct_communication_label
            // 
            this.Selct_communication_label.AutoSize = true;
            this.Selct_communication_label.Location = new System.Drawing.Point(28, 93);
            this.Selct_communication_label.Name = "Selct_communication_label";
            this.Selct_communication_label.Size = new System.Drawing.Size(64, 12);
            this.Selct_communication_label.TabIndex = 5;
            this.Selct_communication_label.Text = "通信コマンド";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(181, 93);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(40, 12);
            this.ID_label.TabIndex = 7;
            this.ID_label.Text = "ID番号";
            // 
            // Select_IDnumber
            // 
            this.Select_IDnumber.FormattingEnabled = true;
            this.Select_IDnumber.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03"});
            this.Select_IDnumber.Location = new System.Drawing.Point(151, 108);
            this.Select_IDnumber.Name = "Select_IDnumber";
            this.Select_IDnumber.Size = new System.Drawing.Size(81, 20);
            this.Select_IDnumber.TabIndex = 6;
            // 
            // Data_Label
            // 
            this.Data_Label.AutoSize = true;
            this.Data_Label.Location = new System.Drawing.Point(297, 93);
            this.Data_Label.Name = "Data_Label";
            this.Data_Label.Size = new System.Drawing.Size(33, 12);
            this.Data_Label.TabIndex = 9;
            this.Data_Label.Text = "データ";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(2, 156);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(370, 19);
            this.resultBox.TabIndex = 10;
            // 
            // result_Label
            // 
            this.result_Label.AutoSize = true;
            this.result_Label.Location = new System.Drawing.Point(181, 141);
            this.result_Label.Name = "result_Label";
            this.result_Label.Size = new System.Drawing.Size(34, 12);
            this.result_Label.TabIndex = 11;
            this.result_Label.Text = "result";
            // 
            // SensorTest_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 204);
            this.Controls.Add(this.result_Label);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.Data_Label);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.Select_IDnumber);
            this.Controls.Add(this.Selct_communication_label);
            this.Controls.Add(this.Select_Communication_Command);
            this.Controls.Add(this.value);
            this.Controls.Add(this.Communication_Button);
            this.Controls.Add(this.Select_Port_Label);
            this.Controls.Add(this.Port_Select);
            this.Name = "SensorTest_form";
            this.Text = "キーエンスセンサテスト";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox Port_Select;
        private System.Windows.Forms.Label Select_Port_Label;
        private System.Windows.Forms.Button Communication_Button;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.ComboBox Select_Communication_Command;
        private System.Windows.Forms.Label Selct_communication_label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.ComboBox Select_IDnumber;
        private System.Windows.Forms.Label Data_Label;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label result_Label;
    }
}

