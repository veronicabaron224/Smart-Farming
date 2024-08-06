using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace CAL_Lab4
{
    public partial class Form1 : Form
    {
        private SerialPort arduino;
        private int soilSensorVal;

        public Form1()
        {
            InitializeComponent();

            arduino = new SerialPort();
            arduino.PortName = "COM8";
            arduino.BaudRate = 9600;
            arduino.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arduino.Close();
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            this.BeginInvoke(new Action(() =>
            {
                ProcessReceivedData(indata);
            }));
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            arduino.Open();
        }

        private void disconnect_btn_Click(object sender, EventArgs e)
        {
            arduino.Close();
            switch_btn.Enabled = false;
            progressBar.Value = 0;
        }

        private void switch_btn_Click(object sender, EventArgs e)
        {
            if (switch_btn.Text == "ON")
            {
                arduino.Write("A");
                switch_btn.Text = "OFF";
            }
            else
            {
                arduino.Write("B");
                switch_btn.Text = "ON";
            }
        }

        private void ProcessReceivedData(string data)
        {
            string[] serialVal = data.Split(',');

            Int32.TryParse(serialVal[0], out soilSensorVal);

            // Set bar value
            if (soilSensorVal < 1000)
            {
                progressBar.Value = soilSensorVal;
                progressBar.Refresh();

                // Disable switch depending on water level
                if (soilSensorVal < 370)
                {
                    switch_btn.Enabled = false;
                }
            }
            else
            {
                progressBar.Value = 999;
            }

            // Enable/disable motor switch depending on value
            if (soilSensorVal < 370)
            {
                switch_btn.Enabled = false;
            }
            else
            {
                switch_btn.Enabled = true;
            }
        }
    }
}
