using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text;

namespace coms
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private string _message;

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
            byte[] bytesToSend = Encoding.ASCII.GetBytes(_sendTextBox.Text.ToString());
            _sendTextBox.Text = "";

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
