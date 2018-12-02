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

namespace ProgWSrodWin
{
    public partial class Form1 : Form
    {
        private SerialPort _serialPort = new SerialPort("COM4", 300, Parity.None, 8, StopBits.One);
        private byte[] _message = { 0xAA };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _serialPort.WriteTimeout = 2000;
            _serialPort.ReadTimeout = 2000;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            _serialPort.Open();

            _serialPort.Write(_message, 0, _message.Length);
            //textBox.Text = _serialPort.ReadByte().ToString();

            _serialPort.Close();
        }
    }
}
