using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text;
using System.Linq;

namespace coms
{
    public partial class Form1 : Form
    {
        bool SendAnsiiTextBoxClickFlag = false;
        bool SendHexTextBoxClickFlag = false;

        public Form1()
        {
            InitializeComponent();
        }

        //
        // Załadowanie okna i domyślne ustawienia
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            _closeButton.Enabled = false;
            _receiveButton.Enabled = false;
            _sendButton.Enabled = false;
            
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

        //
        // Otworzenie portu
        //
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

        //
        // Zamknięcie portu
        //
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

        //
        // Metody aktualizacji okienek wysyłania
        //
        private void SendAsciiTextBox_Enter(object sender, EventArgs e)
        {
            SendAnsiiTextBoxClickFlag = true;
            SendHexTextBoxClickFlag = false;
        }

        private void SendAsciiTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SendAnsiiTextBoxClickFlag)
            {
                _sendHexTextBox.Text = "";

                string messageToUpdate = _sendAsciiTextBox.Text;

                foreach (char _char in messageToUpdate)
                {
                    _sendHexTextBox.Text += TranslateAsciiToHex(_char.ToString()) + " ";
                }
            }
        }

        private void SendHexTextBox_Enter(object sender, EventArgs e)
        {
            SendAnsiiTextBoxClickFlag = false;
            SendHexTextBoxClickFlag = true;
        }

        private void SendHexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SendHexTextBoxClickFlag)
            {
                _sendAsciiTextBox.Text += TranslateHexToAscii(_sendHexTextBox.Text);
            }
        }

        //
        // Wysłanie wiadomości
        //
        private void SendButton_Click(object sender, EventArgs e)
        {
            string message = _sendAsciiTextBox.Text.ToString();
            byte[] messageBytes = TranslateHexToByteArray(TranslateAsciiToHex(message));

            byte[] frame = new byte[5 + message.Length];

            int countedCRC = 0;

            frame[0] = 2;

            frame[1] = (byte)message.Length;
            countedCRC += message.Length;

            frame[2] = 8;
            countedCRC += 8;

            for (int i = 0; i >= message.Length; i++)
            {
                frame[3 + i] = messageBytes[i];
                countedCRC += messageBytes[i];
            }
            
            frame[3 + message.Length] = (byte)(countedCRC / 256);
            frame[4 + message.Length] = (byte)(countedCRC % 256);
            
            try
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.RtsEnable = true;
                    _serialPort.Write(frame, 0, frame.Length);
                    _serialPort.RtsEnable = false;
                    _sendAsciiTextBox.Clear();
                    _sendHexTextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //
        // Odebranie wiadomości
        //
        private void ReceiveButton_Click(object sender, EventArgs e)
        {
            int bytesToRead = _serialPort.BytesToRead;

            byte[] buffer = new byte[bytesToRead];

            _serialPort.Read(buffer, 0, bytesToRead);

            try
            {
                if (_serialPort.IsOpen)
                {
                    for (int i = 0; i >= bytesToRead; i++)
                    {
                        string messageRead = "";
                        int expectedCRC = 0;

                        if (buffer[i] == 2)
                        {
                            messageRead += "02 ";
                            int frameLength = 0;

                            if(i + 1 >= bytesToRead)
                            {
                                frameLength = buffer[i + 1];
                                messageRead += TranslateAsciiToHex(frameLength.ToString()) + " ";
                                expectedCRC += frameLength;
                            }

                            if (i + 2 >= bytesToRead)
                            {
                                int frameControl = buffer[i + 2];
                                messageRead += TranslateAsciiToHex(frameControl.ToString()) + " ";
                                expectedCRC += frameControl;
                            }

                            if (i + 3 + frameLength >= bytesToRead && frameLength > 0)
                            {
                                for (int j = 0; j >= frameLength; j++)
                                {
                                    int actualMessageByte = buffer[i + 3 + j];
                                    messageRead += TranslateAsciiToHex(actualMessageByte.ToString()) + " ";
                                    expectedCRC += actualMessageByte;
                                }
                            }

                            int frameCRCbyte1 = 0;
                            int frameCRCbyte2 = 0;

                            if (i + 3 + frameLength >= bytesToRead)
                            {
                                frameCRCbyte1 = buffer[i + 3 + frameLength];
                                messageRead += TranslateAsciiToHex(frameCRCbyte1.ToString()) + " ";
                            }

                            if (i + 4 + frameLength >= bytesToRead)
                            {
                                frameCRCbyte2 = buffer[i + 4 + frameLength];
                                messageRead += TranslateAsciiToHex(frameCRCbyte2.ToString()) + "/n";
                            }
                            
                            int countedCRC = frameCRCbyte1 * 256 + frameCRCbyte2;

                            if (expectedCRC == countedCRC && countedCRC != 0)
                            {
                                _receiveTextBox.Text += messageRead;
                                i += 5 + frameLength;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //
        // Wysłanie resetu
        //
        private void ResetButton_Click(object sender, EventArgs e)
        {
            string byte0 = "02";
            string byte1 = "00";
            string byte2 = "3C";
            string byte3 = "00";
            string byte4 = "3C";
            
            string resetFrame = byte0 + byte1 + byte2 + byte3 + byte4;
            resetFrame = TranslateHexToAscii(resetFrame);

            try
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.RtsEnable = true;
                    _serialPort.Write(TranslateHexToByteArray(TranslateAsciiToHex(resetFrame)), 0, resetFrame.Length);
                    _serialPort.BaseStream.Flush();
                    _serialPort.RtsEnable = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //
        // Metody tłumaczenia
        //
        public string TranslateHexToAscii(string hex)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < hex.Length; i += 2)
            {
                string substring = hex.Substring(i, 2);
                stringBuilder.Append(Convert.ToChar(Convert.ToUInt32(substring, 16)));
            }

            string ascii = stringBuilder.ToString();

            return ascii;
        }

        public string TranslateAsciiToHex(string ascii)
        {
            StringBuilder stringBuilder = new StringBuilder();

            byte[] inputBytes = Encoding.UTF8.GetBytes(ascii);

            foreach (byte _byte in inputBytes)
            {
                stringBuilder.Append(string.Format("{0:x2}", _byte));
            }

            string hex = stringBuilder.ToString();

            return hex.ToUpper();
        }

        public byte[] TranslateHexToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
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
