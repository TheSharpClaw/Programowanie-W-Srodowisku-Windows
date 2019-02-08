using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text;
using System.Linq;

namespace coms
{
    public partial class Form1 : Form
    {

        public byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

    public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Default enable states for buttons
            _closeButton.Enabled = false;
            _receiveButton.Enabled = false;
            _sendButton.Enabled = false;

            //RadioButtons checked by default
            _modeDLRadioButton.Checked = true;
            _modulationBPSKRadioButton.Checked = true;

            string[] ports = SerialPort.GetPortNames();
            _listOfPortsComboBox.Items.AddRange(ports);

            try
            {
                _listOfPortsComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            _serialPort.RtsEnable = false;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            _openButton.Enabled = false;
            _closeButton.Enabled = true;
            _receiveButton.Enabled = true;
            _sendButton.Enabled = true;

            try
            {
                _serialPort.PortName = _listOfPortsComboBox.Text;
                _serialPort.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

                _openButton.Enabled = true;
                _closeButton.Enabled = false;
                _receiveButton.Enabled = false;
                _sendButton.Enabled = false;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            _openButton.Enabled = true;
            _closeButton.Enabled = false;
            _receiveButton.Enabled = false;
            _sendButton.Enabled = false;

            try
            {
                _serialPort.Close();             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string message = _sendTextBox.Text.ToString();

            string[] listOfSplittedStrings = message.Split((char)32);

            List<byte> listOfBytesToSend = new List<byte>();

            message = "";
            
            for (int i = 0; i <= listOfSplittedStrings.Length - 1; i++)
            {
                if (listOfSplittedStrings[i].StartsWith("0x"))
                {
                    message += listOfSplittedStrings[i].Substring(2);
                }
                else
                {
                    MessageBox.Show("Nieprawidłowa ramka. Prawidłowy format wpisywania ramki: 0xFF 0xFF 0xFF itd.");
                    break;
                }
            }
            
            byte[] bytesToSend = StringToByteArray(message);

            try
            {
                if (_serialPort.IsOpen)
                {             
                    _serialPort.Write(bytesToSend, 0, bytesToSend.Length);
                    _sendTextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReceiveButton_Click(object sender, EventArgs e)
        {
            byte[] bytesToRead = new byte[_serialPort.BytesToRead];

            //Hack:
            //_receiveTextBox.Text = _message;

            try
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Read(bytesToRead, 0, bytesToRead.Length);
                    _receiveTextBox.Text = Encoding.ASCII.GetString(bytesToRead);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_serialPort.IsOpen)
            {
                _serialPort.Close();
            }
        }
    }
}
