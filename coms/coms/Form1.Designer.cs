namespace coms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._portLabel = new System.Windows.Forms.Label();
            this._listOfPortsComboBox = new System.Windows.Forms.ComboBox();
            this._openButton = new System.Windows.Forms.Button();
            this._closeButton = new System.Windows.Forms.Button();
            this._sendAsciiTextBox = new System.Windows.Forms.TextBox();
            this._sendButton = new System.Windows.Forms.Button();
            this._receiveButton = new System.Windows.Forms.Button();
            this._receiveTextBox = new System.Windows.Forms.TextBox();
            this._sendAnsiiLabel = new System.Windows.Forms.Label();
            this._receiveLabel = new System.Windows.Forms.Label();
            this._serialPort = new System.IO.Ports.SerialPort(this.components);
            this._modeDLRadioButton = new System.Windows.Forms.RadioButton();
            this._modeGroupBox = new System.Windows.Forms.GroupBox();
            this._modePHYRadioButton = new System.Windows.Forms.RadioButton();
            this._modulationGroupBox = new System.Windows.Forms.GroupBox();
            this._modulationBPSKPNARadioButton = new System.Windows.Forms.RadioButton();
            this._modulation8PSKRadioButton = new System.Windows.Forms.RadioButton();
            this._modulationBPSKRadioButton = new System.Windows.Forms.RadioButton();
            this._modulationQPSKRadioButton = new System.Windows.Forms.RadioButton();
            this._FECCheckBox = new System.Windows.Forms.CheckBox();
            this._resetButton = new System.Windows.Forms.Button();
            this._sendHexTextBox = new System.Windows.Forms.TextBox();
            this._sendHexLabel = new System.Windows.Forms.Label();
            this._modeGroupBox.SuspendLayout();
            this._modulationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _portLabel
            // 
            this._portLabel.AutoSize = true;
            this._portLabel.Location = new System.Drawing.Point(11, 9);
            this._portLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._portLabel.Name = "_portLabel";
            this._portLabel.Size = new System.Drawing.Size(26, 13);
            this._portLabel.TabIndex = 0;
            this._portLabel.Text = "Port";
            // 
            // _listOfPortsComboBox
            // 
            this._listOfPortsComboBox.FormattingEnabled = true;
            this._listOfPortsComboBox.Location = new System.Drawing.Point(41, 7);
            this._listOfPortsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this._listOfPortsComboBox.Name = "_listOfPortsComboBox";
            this._listOfPortsComboBox.Size = new System.Drawing.Size(200, 21);
            this._listOfPortsComboBox.TabIndex = 1;
            // 
            // _openButton
            // 
            this._openButton.Location = new System.Drawing.Point(245, 7);
            this._openButton.Margin = new System.Windows.Forms.Padding(2);
            this._openButton.Name = "_openButton";
            this._openButton.Size = new System.Drawing.Size(46, 23);
            this._openButton.TabIndex = 2;
            this._openButton.Text = "Open";
            this._openButton.UseVisualStyleBackColor = true;
            this._openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // _closeButton
            // 
            this._closeButton.Location = new System.Drawing.Point(295, 7);
            this._closeButton.Margin = new System.Windows.Forms.Padding(2);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(46, 23);
            this._closeButton.TabIndex = 3;
            this._closeButton.Text = "Close";
            this._closeButton.UseVisualStyleBackColor = true;
            this._closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // _sendAsciiTextBox
            // 
            this._sendAsciiTextBox.Location = new System.Drawing.Point(11, 126);
            this._sendAsciiTextBox.Margin = new System.Windows.Forms.Padding(2);
            this._sendAsciiTextBox.Multiline = true;
            this._sendAsciiTextBox.Name = "_sendAsciiTextBox";
            this._sendAsciiTextBox.Size = new System.Drawing.Size(330, 45);
            this._sendAsciiTextBox.TabIndex = 15;
            this._sendAsciiTextBox.TextChanged += new System.EventHandler(this.SendAsciiTextBox_TextChanged);
            this._sendAsciiTextBox.Enter += new System.EventHandler(this.SendAsciiTextBox_Enter);
            // 
            // _sendButton
            // 
            this._sendButton.Location = new System.Drawing.Point(283, 237);
            this._sendButton.Margin = new System.Windows.Forms.Padding(2);
            this._sendButton.Name = "_sendButton";
            this._sendButton.Size = new System.Drawing.Size(58, 22);
            this._sendButton.TabIndex = 18;
            this._sendButton.Text = "Send";
            this._sendButton.UseVisualStyleBackColor = true;
            this._sendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // _receiveButton
            // 
            this._receiveButton.Location = new System.Drawing.Point(283, 393);
            this._receiveButton.Margin = new System.Windows.Forms.Padding(2);
            this._receiveButton.Name = "_receiveButton";
            this._receiveButton.Size = new System.Drawing.Size(58, 22);
            this._receiveButton.TabIndex = 21;
            this._receiveButton.Text = "Receive";
            this._receiveButton.UseVisualStyleBackColor = true;
            this._receiveButton.Click += new System.EventHandler(this.ReceiveButton_Click);
            // 
            // _receiveTextBox
            // 
            this._receiveTextBox.Location = new System.Drawing.Point(11, 263);
            this._receiveTextBox.Margin = new System.Windows.Forms.Padding(2);
            this._receiveTextBox.Multiline = true;
            this._receiveTextBox.Name = "_receiveTextBox";
            this._receiveTextBox.ReadOnly = true;
            this._receiveTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._receiveTextBox.Size = new System.Drawing.Size(330, 126);
            this._receiveTextBox.TabIndex = 20;
            // 
            // _sendAnsiiLabel
            // 
            this._sendAnsiiLabel.AutoSize = true;
            this._sendAnsiiLabel.Location = new System.Drawing.Point(11, 111);
            this._sendAnsiiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._sendAnsiiLabel.Name = "_sendAnsiiLabel";
            this._sendAnsiiLabel.Size = new System.Drawing.Size(68, 13);
            this._sendAnsiiLabel.TabIndex = 14;
            this._sendAnsiiLabel.Text = "Send (ASCII)";
            // 
            // _receiveLabel
            // 
            this._receiveLabel.AutoSize = true;
            this._receiveLabel.Location = new System.Drawing.Point(11, 246);
            this._receiveLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._receiveLabel.Name = "_receiveLabel";
            this._receiveLabel.Size = new System.Drawing.Size(47, 13);
            this._receiveLabel.TabIndex = 19;
            this._receiveLabel.Text = "Receive";
            // 
            // _modeDLRadioButton
            // 
            this._modeDLRadioButton.AutoSize = true;
            this._modeDLRadioButton.Location = new System.Drawing.Point(6, 19);
            this._modeDLRadioButton.Name = "_modeDLRadioButton";
            this._modeDLRadioButton.Size = new System.Drawing.Size(39, 17);
            this._modeDLRadioButton.TabIndex = 5;
            this._modeDLRadioButton.TabStop = true;
            this._modeDLRadioButton.Text = "DL";
            this._modeDLRadioButton.UseVisualStyleBackColor = true;
            // 
            // _modeGroupBox
            // 
            this._modeGroupBox.Controls.Add(this._modePHYRadioButton);
            this._modeGroupBox.Controls.Add(this._modeDLRadioButton);
            this._modeGroupBox.Location = new System.Drawing.Point(12, 34);
            this._modeGroupBox.Name = "_modeGroupBox";
            this._modeGroupBox.Size = new System.Drawing.Size(61, 64);
            this._modeGroupBox.TabIndex = 4;
            this._modeGroupBox.TabStop = false;
            this._modeGroupBox.Text = "Mode";
            // 
            // _modePHYRadioButton
            // 
            this._modePHYRadioButton.AutoSize = true;
            this._modePHYRadioButton.Location = new System.Drawing.Point(6, 41);
            this._modePHYRadioButton.Name = "_modePHYRadioButton";
            this._modePHYRadioButton.Size = new System.Drawing.Size(47, 17);
            this._modePHYRadioButton.TabIndex = 6;
            this._modePHYRadioButton.TabStop = true;
            this._modePHYRadioButton.Text = "PHY";
            this._modePHYRadioButton.UseVisualStyleBackColor = true;
            // 
            // _modulationGroupBox
            // 
            this._modulationGroupBox.Controls.Add(this._modulationBPSKPNARadioButton);
            this._modulationGroupBox.Controls.Add(this._modulation8PSKRadioButton);
            this._modulationGroupBox.Controls.Add(this._modulationBPSKRadioButton);
            this._modulationGroupBox.Controls.Add(this._modulationQPSKRadioButton);
            this._modulationGroupBox.Location = new System.Drawing.Point(79, 34);
            this._modulationGroupBox.Name = "_modulationGroupBox";
            this._modulationGroupBox.Size = new System.Drawing.Size(136, 64);
            this._modulationGroupBox.TabIndex = 7;
            this._modulationGroupBox.TabStop = false;
            this._modulationGroupBox.Text = "Modulation";
            // 
            // _modulationBPSKPNARadioButton
            // 
            this._modulationBPSKPNARadioButton.AutoSize = true;
            this._modulationBPSKPNARadioButton.Location = new System.Drawing.Point(5, 42);
            this._modulationBPSKPNARadioButton.Name = "_modulationBPSKPNARadioButton";
            this._modulationBPSKPNARadioButton.Size = new System.Drawing.Size(75, 17);
            this._modulationBPSKPNARadioButton.TabIndex = 9;
            this._modulationBPSKPNARadioButton.TabStop = true;
            this._modulationBPSKPNARadioButton.Text = "BPSKPNA";
            this._modulationBPSKPNARadioButton.UseVisualStyleBackColor = true;
            // 
            // _modulation8PSKRadioButton
            // 
            this._modulation8PSKRadioButton.AutoSize = true;
            this._modulation8PSKRadioButton.Location = new System.Drawing.Point(82, 42);
            this._modulation8PSKRadioButton.Name = "_modulation8PSKRadioButton";
            this._modulation8PSKRadioButton.Size = new System.Drawing.Size(52, 17);
            this._modulation8PSKRadioButton.TabIndex = 11;
            this._modulation8PSKRadioButton.TabStop = true;
            this._modulation8PSKRadioButton.Text = "8PSK";
            this._modulation8PSKRadioButton.UseVisualStyleBackColor = true;
            // 
            // _modulationBPSKRadioButton
            // 
            this._modulationBPSKRadioButton.AutoSize = true;
            this._modulationBPSKRadioButton.Location = new System.Drawing.Point(5, 19);
            this._modulationBPSKRadioButton.Name = "_modulationBPSKRadioButton";
            this._modulationBPSKRadioButton.Size = new System.Drawing.Size(53, 17);
            this._modulationBPSKRadioButton.TabIndex = 8;
            this._modulationBPSKRadioButton.TabStop = true;
            this._modulationBPSKRadioButton.Text = "BPSK";
            this._modulationBPSKRadioButton.UseVisualStyleBackColor = true;
            // 
            // _modulationQPSKRadioButton
            // 
            this._modulationQPSKRadioButton.AutoSize = true;
            this._modulationQPSKRadioButton.Location = new System.Drawing.Point(82, 19);
            this._modulationQPSKRadioButton.Name = "_modulationQPSKRadioButton";
            this._modulationQPSKRadioButton.Size = new System.Drawing.Size(54, 17);
            this._modulationQPSKRadioButton.TabIndex = 10;
            this._modulationQPSKRadioButton.TabStop = true;
            this._modulationQPSKRadioButton.Text = "QPSK";
            this._modulationQPSKRadioButton.UseVisualStyleBackColor = true;
            // 
            // _FECCheckBox
            // 
            this._FECCheckBox.AutoSize = true;
            this._FECCheckBox.Location = new System.Drawing.Point(221, 77);
            this._FECCheckBox.Name = "_FECCheckBox";
            this._FECCheckBox.Size = new System.Drawing.Size(46, 17);
            this._FECCheckBox.TabIndex = 12;
            this._FECCheckBox.Text = "FEC";
            this._FECCheckBox.UseVisualStyleBackColor = true;
            // 
            // _resetButton
            // 
            this._resetButton.Location = new System.Drawing.Point(283, 76);
            this._resetButton.Margin = new System.Windows.Forms.Padding(2);
            this._resetButton.Name = "_resetButton";
            this._resetButton.Size = new System.Drawing.Size(58, 22);
            this._resetButton.TabIndex = 13;
            this._resetButton.Text = "Reset";
            this._resetButton.UseVisualStyleBackColor = true;
            this._resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // _sendHexTextBox
            // 
            this._sendHexTextBox.Location = new System.Drawing.Point(11, 188);
            this._sendHexTextBox.Margin = new System.Windows.Forms.Padding(2);
            this._sendHexTextBox.Multiline = true;
            this._sendHexTextBox.Name = "_sendHexTextBox";
            this._sendHexTextBox.ReadOnly = true;
            this._sendHexTextBox.Size = new System.Drawing.Size(330, 45);
            this._sendHexTextBox.TabIndex = 17;
            this._sendHexTextBox.TextChanged += new System.EventHandler(this.SendHexTextBox_TextChanged);
            this._sendHexTextBox.Enter += new System.EventHandler(this.SendHexTextBox_Enter);
            // 
            // _sendHexLabel
            // 
            this._sendHexLabel.AutoSize = true;
            this._sendHexLabel.Location = new System.Drawing.Point(8, 173);
            this._sendHexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._sendHexLabel.Name = "_sendHexLabel";
            this._sendHexLabel.Size = new System.Drawing.Size(63, 13);
            this._sendHexLabel.TabIndex = 16;
            this._sendHexLabel.Text = "Send (HEX)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 421);
            this.Controls.Add(this._sendHexLabel);
            this.Controls.Add(this._sendHexTextBox);
            this.Controls.Add(this._resetButton);
            this.Controls.Add(this._FECCheckBox);
            this.Controls.Add(this._modulationGroupBox);
            this.Controls.Add(this._modeGroupBox);
            this.Controls.Add(this._receiveLabel);
            this.Controls.Add(this._sendAnsiiLabel);
            this.Controls.Add(this._receiveButton);
            this.Controls.Add(this._receiveTextBox);
            this.Controls.Add(this._sendButton);
            this.Controls.Add(this._sendAsciiTextBox);
            this.Controls.Add(this._closeButton);
            this.Controls.Add(this._openButton);
            this.Controls.Add(this._listOfPortsComboBox);
            this.Controls.Add(this._portLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this._modeGroupBox.ResumeLayout(false);
            this._modeGroupBox.PerformLayout();
            this._modulationGroupBox.ResumeLayout(false);
            this._modulationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label _portLabel;
        private System.Windows.Forms.ComboBox _listOfPortsComboBox;
        private System.Windows.Forms.Button _openButton;
        private System.Windows.Forms.Button _closeButton;
        private System.Windows.Forms.TextBox _sendAsciiTextBox;
        private System.Windows.Forms.Button _sendButton;
        private System.Windows.Forms.Button _receiveButton;
        private System.Windows.Forms.TextBox _receiveTextBox;
        private System.Windows.Forms.Label _sendAnsiiLabel;
        private System.Windows.Forms.Label _receiveLabel;
        private System.IO.Ports.SerialPort _serialPort;
        private System.Windows.Forms.RadioButton _modeDLRadioButton;
        private System.Windows.Forms.GroupBox _modeGroupBox;
        private System.Windows.Forms.RadioButton _modePHYRadioButton;
        private System.Windows.Forms.GroupBox _modulationGroupBox;
        private System.Windows.Forms.RadioButton _modulationBPSKRadioButton;
        private System.Windows.Forms.RadioButton _modulation8PSKRadioButton;
        private System.Windows.Forms.RadioButton _modulationQPSKRadioButton;
        private System.Windows.Forms.CheckBox _FECCheckBox;
        private System.Windows.Forms.RadioButton _modulationBPSKPNARadioButton;
        private System.Windows.Forms.Button _resetButton;
        private System.Windows.Forms.TextBox _sendHexTextBox;
        private System.Windows.Forms.Label _sendHexLabel;
    }
}

