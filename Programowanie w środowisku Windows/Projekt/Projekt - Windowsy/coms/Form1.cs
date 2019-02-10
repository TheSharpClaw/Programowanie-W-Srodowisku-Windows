using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Text;

namespace coms
{
    public partial class Form1 : Form
    {

        #region VARIABLES
        public enum States { BEGINING, LENGTH, CONTROL, GET_FRAME, CHECK_BAIT, CHECK_CRC }
        //stany: początek, długość, control, pobieranie ramki, Sprawdz 1 bajt, sprawdz CRC
        #endregion

        #region CONSTRUCTOR
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region METHODS 
        private static bool isValid(String str)
        {
            bool valid = false;
            Regex chars = new Regex((@"^([a-fA-F0-9]{2}\s+)+"));
            if (chars.Match(str).Success)
                valid = true;
            else
                valid = false;
            return valid;
        }

        public string ConvertHexToASCII(String hexString)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hexString.Length; i += 2)
            {
                string hs = hexString.Substring(i, 2);
                sb.Append(Convert.ToChar(Convert.ToUInt32(hs, 16)));
            }
            String ascii = sb.ToString();
            return ascii;
        }

        public string ASCIITOHex(string ascii)
        {
            StringBuilder sb = new StringBuilder();
            byte[] inputBytes = Encoding.UTF8.GetBytes(ascii);
            foreach (byte b in inputBytes)
            {
                sb.Append(string.Format("{0:x2}", b));
            }
            string hex = sb.ToString();
            return hex.ToUpper();
        }
        #endregion

        #region CONTROLS
        private void btnOpen_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cboPorts.Items.AddRange(ports);
            cboPorts.SelectedIndex = 0;
            btnClose.Enabled = false;
            btnOpen.Enabled = false;
            btnClose.Enabled = true;
            try
            {
                serialPort1.PortName = cboPorts.Text;
                serialPort1.BaudRate = 57600;
                serialPort1.Parity = Parity.None;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            int bytes = serialPort1.BytesToRead;
            byte[] respBuffer = new byte[bytes];
            serialPort1.Read(respBuffer, 0, bytes);

            States[] checklist = new States[6];
            checklist[0] = States.BEGINING;
            checklist[1] = States.LENGTH;
            checklist[2] = States.CONTROL;
            checklist[3] = States.GET_FRAME;
            checklist[4] = States.CHECK_BAIT;
            checklist[5] = States.CHECK_CRC;

            byte[] correctFrame = new byte[6];
            try
            {
                if (serialPort1.IsOpen)
                {
                    if (checklist[0] == States.BEGINING)
                    {
                        if (respBuffer[0].ToString() == "2")
                        {
                            correctFrame[0] = respBuffer[0];
                        }
                        else
                        {
                            MessageBox.Show("Nie odnaleziono początku ramki!!!");
                            return;
                        }
                    }
                    if (checklist[1] == States.LENGTH)
                    {
                        if (ASCIITOHex(respBuffer[1].ToString()) != null)
                        {
                            correctFrame[1] = respBuffer[1];
                        }
                        else
                        {
                            MessageBox.Show("Nieznana długość ramki!!!");
                            return;
                        }
                    }
                    if (checklist[2] == States.CONTROL)
                    {
                        if (ASCIITOHex(respBuffer[2].ToString()) != null)
                        {
                            correctFrame[2] = respBuffer[2];
                        }
                        else
                        {
                            MessageBox.Show("Nie rozpoznano kontroli!!!");
                            return;
                        }
                    }
                    if (checklist[3] == States.GET_FRAME)
                    {
                        if (ASCIITOHex(respBuffer[3].ToString()) != null)
                        {
                            correctFrame[3] = respBuffer[3];
                        }
                        else
                        {
                            MessageBox.Show("Nie rozpoznano ramki!!!");
                            return;
                        }
                    }
                    if (checklist[4] == States.CHECK_BAIT)
                    {
                        if (ASCIITOHex(respBuffer[4].ToString()) != null)
                        {
                            correctFrame[4] = respBuffer[4];
                        }
                        else
                        {
                            MessageBox.Show("Nie rozpoznano instrukcji!!!");
                            return;
                        }
                    }
                    if (checklist[5] == States.CHECK_CRC)
                    {
                        if (ASCIITOHex(respBuffer[5].ToString()) != null)
                        {
                            correctFrame[5] = respBuffer[5];
                            string ACK = ConvertHexToASCII("06");
                            serialPort1.Write(ACK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nie znaleziono końca ramki!!!");
                        return;
                    }
                }
                string hex = BitConverter.ToString(correctFrame).Replace("-", " ");
                txtReceive.Text += hex;
                txtReceive.Text += " \n";
                Array.Clear(respBuffer, 0, respBuffer.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void clearScrollback_Click(object sender, EventArgs e)
        {
            txtReceive.Text = String.Empty;
            txtMessageASCII.Text = String.Empty;
        }

        private void sendReset_Click(object sender, EventArgs e)
        {
            string frame0 = "02";
            string frame1 = "00";
            string frame2 = "3C";
            string frame3 = "3C";
            string frame4 = "00";
            string resetFrame = "";
            frame0 = ConvertHexToASCII(frame0);
            frame1 = ConvertHexToASCII(frame1);
            frame2 = ConvertHexToASCII(frame2);
            frame3 = ConvertHexToASCII(frame3);
            frame4 = ConvertHexToASCII(frame4);
            resetFrame = frame0 + frame1 + frame2 + frame3 + frame4;
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.RtsEnable = true;
                    serialPort1.WriteLine(resetFrame);
                    serialPort1.BaseStream.Flush();
                    serialPort1.RtsEnable = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            if (isValid(message) == false)
            {
                MessageBox.Show("Błąd składni!!! Brak liczby w formacie heksadecymalnym!!! (Przykład: FF, A0)");
                return;
            }
            message = message.Replace(" ", String.Empty);
            if (message.Length % 2 != 0)
            {
                MessageBox.Show("Podana ramka jest błędna! Sprawdz wysyłane wartości!");
                return;
            }
            int length;
            length = message.Length / 2;
            string[] frame = new string[length];
            for (int i = 0; i < length; i++)
            {
                frame[i] = message.Substring(i * 2, 2);
            }
            string finalFrame = "";
            for (int i = 0; i < length; i++)
            {
                finalFrame += ConvertHexToASCII(frame[i]);
            }
            if (serialPort1.IsOpen)
            {
                serialPort1.RtsEnable = true;
                serialPort1.Write(finalFrame);
                serialPort1.RtsEnable = false;
            }
            txtMessageASCII.Text += finalFrame;
        }
        #endregion

        #region Kontrolki
        private void BPSK_button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void QSK_button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EPSK_button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DL_Button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PH_button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FEC_checkbox_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

    }
}