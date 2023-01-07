using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyenceSensorTest
{
    public partial class SensorTest_form : Form
    {
        public SensorTest_form()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            resultBox.ReadOnly = true;
            string[] ports = SerialPort.GetPortNames();
            
            foreach (string port in ports)
            {
                this.Port_Select.Items.Add(port);
            }
            if (this.Port_Select.Items.Count > 0)
            {
                this.Port_Select.SelectedIndex = 0;

            }
        }

        private void Communication_Click(object sender, EventArgs e)
        {
            if(resultBox.Text != "")
            {
                resultBox.Text = "";
            }
            if (this.Port_Select.SelectedIndex > -1)
            {
                if (this.serialPort1.PortName != this.Port_Select.SelectedItem.ToString())
                {
                    if (this.serialPort1.IsOpen)
                    {
                        this.serialPort1.Close();
                    }
                    this.serialPort1.PortName = this.Port_Select.SelectedItem.ToString();
                    
                    Debug.WriteLine(serialPort1.PortName);
                    this.serialPort1.Open();
                }
                else
                {
                    if (!this.serialPort1.IsOpen)
                    {
                        this.serialPort1.Open();
                    }
                }

                if (Select_Communication_Command.Items[Select_Communication_Command.SelectedIndex] != "")
                {
                    String communication;
                    if (Select_Communication_Command.Items[Select_Communication_Command.SelectedIndex] == "MS" || Select_Communication_Command.Items[Select_Communication_Command.SelectedIndex] == "M0")
                    {
                        communication = Select_Communication_Command.Items[Select_Communication_Command.SelectedIndex].ToString() + "\r\n";
                    }
                    else
                    {
                        communication = Select_Communication_Command.Items[Select_Communication_Command.SelectedIndex] + "," + Select_IDnumber.Items[Select_IDnumber.SelectedIndex] + "," + value.Text + "\r\n";
                    }
                    this.serialPort1.Write(communication);
                }
                else
                {
                    MessageBox.Show("入力が完了されていません");
                }
            }
        }

        String result = "";
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                result = result + this.serialPort1.ReadExisting();
                resultBox.Text = resultBox.Text + result;
            }));
            
            result = "";
            //Console.WriteLine(this.serialPort1.ReadExisting());
        }

        private void serialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                resultBox.Text = "Err.";
            }));
        }

        private void Select_Communication_Command_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combobox = (ComboBox)sender;
            if(combobox.Items[combobox.SelectedIndex] == "M0" || combobox.Items[combobox.SelectedIndex] == "MS")
            {
                Select_IDnumber.Items.Clear();
                value.ReadOnly = true;
            }
            else
            {
                if (Select_IDnumber.Items.Count == 0)
                {
                    Select_IDnumber.Items.Insert(0, "00");
                    Select_IDnumber.Items.Insert(1, "01");
                    Select_IDnumber.Items.Insert(2, "02");
                    Select_IDnumber.Items.Insert(3, "03");
                }
                value.ReadOnly = false;
            }
        }
    }
}
