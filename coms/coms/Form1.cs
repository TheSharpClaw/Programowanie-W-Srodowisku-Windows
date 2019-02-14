using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text;
using System.Threading;

namespace coms
{
    public partial class Form1 : Form
    {
        //
        // Global variables
        //
        bool _fec = false;
        byte _commandCode = 0x24;
        byte _firstByte = 0x04;
        int _byteArrayLength;
        byte[] _byteArray;
        //
        // Form initialization
        //
        public Form1()
        {
            InitializeComponent();
        }
        //
        // Form loading and default options
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            _openButton.Enabled = true;
            _closeButton.Enabled = false;

            _modeDLRadioButton.Enabled = false;
            _modePHYRadioButton.Enabled = false;

            _modulationBPSKRadioButton.Enabled = false;
            _modulationQPSKRadioButton.Enabled = false;
            _modulation8PSKRadioButton.Enabled = false;

            _FECCheckBox.Enabled = false;

            _resetButton.Enabled = false;

            _sendButton.Enabled = false;
            _receiveButton.Enabled = false;

            string[] ports = SerialPort.GetPortNames();
            _listOfPortsComboBox.Items.AddRange(ports);

            try
            {
                _listOfPortsComboBox.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Brak dostępnych portów!");
            }

            _serialPort.RtsEnable = false;
        }
        //
        // Port opening
        //
        private void OpenButton_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.PortName = _listOfPortsComboBox.Text;
                _serialPort.BaudRate = 57600;

                _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedEventHandler);

                _serialPort.Open();

                _openButton.Enabled = false;
                _closeButton.Enabled = true;

                _modeDLRadioButton.Enabled = true;
                _modePHYRadioButton.Enabled = true;

                _modulationBPSKRadioButton.Enabled = true;
                _modulationQPSKRadioButton.Enabled = true;
                _modulation8PSKRadioButton.Enabled = true;

                _FECCheckBox.Enabled = true;

                _resetButton.Enabled = true;

                _sendButton.Enabled = true;
                _receiveButton.Enabled = true;

                _modePHYRadioButton.Checked = true;
                _modulationBPSKRadioButton.Checked = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Nie udało się otworzyć portu!");
            }
        }
        //
        // Port closing
        //
        private void CloseButton_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.Close();

                _openButton.Enabled = true;
                _closeButton.Enabled = false;

                _modeDLRadioButton.Enabled = false;
                _modePHYRadioButton.Enabled = false;

                _modulationBPSKRadioButton.Enabled = false;
                _modulationQPSKRadioButton.Enabled = false;
                _modulation8PSKRadioButton.Enabled = false;

                _FECCheckBox.Enabled = false;
                _fec = false;

                _resetButton.Enabled = false;

                _sendButton.Enabled = false;
                _receiveButton.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Nie udało się zamknąć portu!");
            }
        }
        //
        // Mode selection
        //
        private void ModeDLRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (_modeDLRadioButton.Checked == true)
            {
                _commandCode = 0x50;

                byte[] setMode = new byte[] { 0x08, 0x00, 0x11 };

                _serialPort.RtsEnable = true;

                _serialPort.Write(setMode, 0, setMode.Length);
                Thread.Sleep(100);

                _serialPort.RtsEnable = false;
                _serialPort.BaseStream.Flush();
            }
        }

        private void ModePHYRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (_modePHYRadioButton.Checked == true)
            {
                _commandCode = 0x24;

                byte[] setMode = new byte[] { 0x08, 0x00, 0x10 };

                _serialPort.RtsEnable = true;

                _serialPort.Write(setMode, 0, setMode.Length);
                Thread.Sleep(100);

                _serialPort.RtsEnable = false;
                _serialPort.BaseStream.Flush();
            }
        }
        //
        // Modulation selection
        //
        private void ModulationBPSKRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (_modulationBPSKRadioButton.Checked == true)
            {
                if (_fec == false)
                    _firstByte = 0x04;
                else
                    _firstByte = 0x44;
            }
        }

        private void ModulationQPSKRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (_modulationQPSKRadioButton.Checked == true)
            {
                if (_fec == false)
                    _firstByte = 0x14;
                else
                    _firstByte = 0x54;
            }
        }

        private void Modulation8PSKRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (_modulation8PSKRadioButton.Checked == true)
            {
                if (_fec == false)
                    _firstByte = 0x24;
                else
                    _firstByte = 0x64;
            }
        }
        //
        // FEC selection
        //
        private void FECCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_fec == false)
            {
                _firstByte += 0x40;
                _fec = true;
            }
            else
            {
                _firstByte -= 0x40;
                _fec = false;
            }
        }
        //
        // Reset sending
        //
        private void ResetButton_Click(object sender, EventArgs e)
        {
            byte[] reset = new byte[] { 0x02, 0x00, 0x3C, 0x3C, 0x00 };

            try
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.RtsEnable = true;

                    _serialPort.Write(reset, 0, reset.Length);
                    Thread.Sleep(100);

                    _serialPort.RtsEnable = false;
                    _serialPort.BaseStream.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //
        // TextBox actualizations 
        //
        private void SendAsciiTextBox_TextChanged(object sender, EventArgs e)
        {
            _sendHexTextBox.Text = TranslateAsciiToHex(_sendAsciiTextBox.Text);
        }

        private void SendHexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_sendHexTextBox.Text.Length >= 1)
                {
                    char lastHexChar = Char.ToLower(_sendHexTextBox.Text[_sendHexTextBox.Text.Length - 1]);

                    if (Char.IsDigit(lastHexChar) || (lastHexChar >= 'a' && lastHexChar <= 'f') || lastHexChar == ' ')
                    {
                        bool spaceFlag = true;

                        for (int i = 0; i < _sendHexTextBox.Text.Length; i++)
                        {
                            if ((i + 1) % 3 == 0 && _sendHexTextBox.Text[i] != ' ')
                                spaceFlag = false;
                        }

                        if (spaceFlag)
                        {
                            if ((_sendHexTextBox.Text.Length % 3) == 0)
                            {
                                string message = "";

                                _byteArrayLength = _sendHexTextBox.Text.Length / 3;
                                _byteArray = new byte[_byteArrayLength];

                                for (int i = 0; i < _sendHexTextBox.Text.Length; i += 3)
                                {
                                    _byteArray[i / 3] = Convert.ToByte(_sendHexTextBox.Text.Substring(i, 2), 16);
                                    message += " " + _byteArray[i / 3];
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Dwa znaki hex muszą być oddzielone spacją!");
                            _sendHexTextBox.Text = _sendHexTextBox.Text.Remove(_sendHexTextBox.Text.Length - 1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wprowadzono znak spoza wartości hex!");
                        _sendHexTextBox.Text = _sendHexTextBox.Text.Remove(_sendHexTextBox.Text.Length - 1);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Błędne dane w polu HEX");
                _sendHexTextBox.Clear();
                _sendAsciiTextBox.Clear();
            }
        }
        //
        // Message sending
        //
        private void SendButton_Click(object sender, EventArgs e)
        {
            if (_sendHexTextBox.Text.Length >= 1)
            {
                byte[] frame = new byte[_byteArrayLength + 6];
                int frameIndex = 0;
                int controlSum = 0;

                frame[frameIndex++] = 0x02;
                frame[frameIndex++] = (byte)(_byteArrayLength + 1);
                frame[frameIndex++] = _commandCode;
                frame[frameIndex++] = _firstByte;

                for (int i = 0; i < _byteArrayLength; i++)
                    frame[frameIndex++] = _byteArray[i];

                for (int i = 1; i < _byteArrayLength + 4; i++)
                    controlSum += frame[i];

                frame[frameIndex++] = (byte)(controlSum % 256);
                frame[frameIndex++] = (byte)(controlSum / 256);

                try
                {
                    if (_serialPort.IsOpen)
                    {
                        _serialPort.RtsEnable = true;

                        _serialPort.Write(frame, 0, frame.Length);

                        _serialPort.RtsEnable = false;
                        //_serialPort.BaseStream.Flush();

                        _sendHexTextBox.Clear();
                        _sendAsciiTextBox.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Brak danych do wysłania!");
            }
            
        }
        //
        // Messages receiving by thread
        //
        private void DataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort serialPort = (SerialPort)sender;
                
                _receiveHistoryTextBox.Invoke(new Action(delegate ()
                {
                    _receiveHistoryTextBox.AppendText(_receiveLastTextBox.Text);
                }));

                _receiveLastTextBox.Invoke(new Action(delegate ()
                {
                    _receiveLastTextBox.Text = serialPort.ReadExisting();
                }));
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Przekroczono limit czasu!");
            }
        }
        //
        // Clearing receive history
        //
        private void _receiveClearButton_Click(object sender, EventArgs e)
        {
            _receiveHistoryTextBox.Clear();
        }
        //
        // Messages receiving by hand
        //
        private void ReceiveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _receiveHistoryTextBox.AppendText(_receiveLastTextBox.Text);
                _receiveLastTextBox.Text = _serialPort.ReadExisting();
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Przekroczono czas oczekiwania!");
            }
        }
        //
        // Translating ascii string to hex string
        //
        public string TranslateAsciiToHex(string ascii)
        {
            byte[] ByteArray = Encoding.ASCII.GetBytes(ascii);

            StringBuilder hex = new StringBuilder();

            foreach (byte b in ByteArray)
            {
                hex.AppendFormat("{0:x2}", b);
                hex.Append(" ");
            }

            return hex.ToString();
        }
        //
        // Zamknięcie okna
        //
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }
        }
    }
}
