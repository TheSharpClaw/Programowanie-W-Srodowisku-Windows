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
            this._receiveHistoryTextBox = new System.Windows.Forms.TextBox();
            this._sendAnsiiLabel = new System.Windows.Forms.Label();
            this._receiveLabel = new System.Windows.Forms.Label();
            this._serialPort = new System.IO.Ports.SerialPort(this.components);
            this._modeDLRadioButton = new System.Windows.Forms.RadioButton();
            this._modeGroupBox = new System.Windows.Forms.GroupBox();
            this._modePHYRadioButton = new System.Windows.Forms.RadioButton();
            this._modulationGroupBox = new System.Windows.Forms.GroupBox();
            this._modulation8PSKRadioButton = new System.Windows.Forms.RadioButton();
            this._modulationBPSKRadioButton = new System.Windows.Forms.RadioButton();
            this._modulationQPSKRadioButton = new System.Windows.Forms.RadioButton();
            this._FECCheckBox = new System.Windows.Forms.CheckBox();
            this._resetButton = new System.Windows.Forms.Button();
            this._sendHexTextBox = new System.Windows.Forms.TextBox();
            this._sendHexLabel = new System.Windows.Forms.Label();
            this._receiveLastTextBox = new System.Windows.Forms.TextBox();
            this._receiveLastLabel = new System.Windows.Forms.Label();
            this._receiveClearButton = new System.Windows.Forms.Button();
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
            this._sendAsciiTextBox.Size = new System.Drawing.Size(330, 26);
            this._sendAsciiTextBox.TabIndex = 14;
            this._sendAsciiTextBox.TextChanged += new System.EventHandler(this.SendAsciiTextBox_TextChanged);
            // 
            // _sendButton
            // 
            this._sendButton.Location = new System.Drawing.Point(283, 218);
            this._sendButton.Margin = new System.Windows.Forms.Padding(2);
            this._sendButton.Name = "_sendButton";
            this._sendButton.Size = new System.Drawing.Size(58, 22);
            this._sendButton.TabIndex = 17;
            this._sendButton.Text = "Send";
            this._sendButton.UseVisualStyleBackColor = true;
            this._sendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // _receiveButton
            // 
            this._receiveButton.Location = new System.Drawing.Point(283, 429);
            this._receiveButton.Margin = new System.Windows.Forms.Padding(2);
            this._receiveButton.Name = "_receiveButton";
            this._receiveButton.Size = new System.Drawing.Size(58, 22);
            this._receiveButton.TabIndex = 23;
            this._receiveButton.Text = "Receive";
            this._receiveButton.UseVisualStyleBackColor = true;
            this._receiveButton.Click += new System.EventHandler(this.ReceiveButton_Click);
            // 
            // _receiveHistoryTextBox
            // 
            this._receiveHistoryTextBox.Location = new System.Drawing.Point(11, 299);
            this._receiveHistoryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this._receiveHistoryTextBox.Multiline = true;
            this._receiveHistoryTextBox.Name = "_receiveHistoryTextBox";
            this._receiveHistoryTextBox.ReadOnly = true;
            this._receiveHistoryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._receiveHistoryTextBox.Size = new System.Drawing.Size(330, 126);
            this._receiveHistoryTextBox.TabIndex = 21;
            // 
            // _sendAnsiiLabel
            // 
            this._sendAnsiiLabel.AutoSize = true;
            this._sendAnsiiLabel.Location = new System.Drawing.Point(9, 111);
            this._sendAnsiiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._sendAnsiiLabel.Name = "_sendAnsiiLabel";
            this._sendAnsiiLabel.Size = new System.Drawing.Size(68, 13);
            this._sendAnsiiLabel.TabIndex = 13;
            this._sendAnsiiLabel.Text = "Send (ASCII)";
            // 
            // _receiveLabel
            // 
            this._receiveLabel.AutoSize = true;
            this._receiveLabel.Location = new System.Drawing.Point(8, 284);
            this._receiveLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._receiveLabel.Name = "_receiveLabel";
            this._receiveLabel.Size = new System.Drawing.Size(82, 13);
            this._receiveLabel.TabIndex = 20;
            this._receiveLabel.Text = "Receive History";
            // 
            // _modeDLRadioButton
            // 
            this._modeDLRadioButton.AutoSize = true;
            this._modeDLRadioButton.Location = new System.Drawing.Point(6, 41);
            this._modeDLRadioButton.Name = "_modeDLRadioButton";
            this._modeDLRadioButton.Size = new System.Drawing.Size(39, 17);
            this._modeDLRadioButton.TabIndex = 5;
            this._modeDLRadioButton.TabStop = true;
            this._modeDLRadioButton.Text = "DL";
            this._modeDLRadioButton.UseVisualStyleBackColor = true;
            this._modeDLRadioButton.CheckedChanged += new System.EventHandler(this.ModeDLRadioButton_CheckedChanged);
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
            this._modePHYRadioButton.Location = new System.Drawing.Point(6, 20);
            this._modePHYRadioButton.Name = "_modePHYRadioButton";
            this._modePHYRadioButton.Size = new System.Drawing.Size(47, 17);
            this._modePHYRadioButton.TabIndex = 6;
            this._modePHYRadioButton.TabStop = true;
            this._modePHYRadioButton.Text = "PHY";
            this._modePHYRadioButton.UseVisualStyleBackColor = true;
            this._modePHYRadioButton.CheckedChanged += new System.EventHandler(this.ModePHYRadioButton_CheckedChanged);
            // 
            // _modulationGroupBox
            // 
            this._modulationGroupBox.Controls.Add(this._modulation8PSKRadioButton);
            this._modulationGroupBox.Controls.Add(this._modulationBPSKRadioButton);
            this._modulationGroupBox.Controls.Add(this._modulationQPSKRadioButton);
            this._modulationGroupBox.Location = new System.Drawing.Point(79, 34);
            this._modulationGroupBox.Name = "_modulationGroupBox";
            this._modulationGroupBox.Size = new System.Drawing.Size(120, 64);
            this._modulationGroupBox.TabIndex = 7;
            this._modulationGroupBox.TabStop = false;
            this._modulationGroupBox.Text = "Modulation";
            // 
            // _modulation8PSKRadioButton
            // 
            this._modulation8PSKRadioButton.AutoSize = true;
            this._modulation8PSKRadioButton.Location = new System.Drawing.Point(64, 19);
            this._modulation8PSKRadioButton.Name = "_modulation8PSKRadioButton";
            this._modulation8PSKRadioButton.Size = new System.Drawing.Size(52, 17);
            this._modulation8PSKRadioButton.TabIndex = 10;
            this._modulation8PSKRadioButton.TabStop = true;
            this._modulation8PSKRadioButton.Text = "8PSK";
            this._modulation8PSKRadioButton.UseVisualStyleBackColor = true;
            this._modulation8PSKRadioButton.CheckedChanged += new System.EventHandler(this.Modulation8PSKRadioButton_CheckedChanged);
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
            this._modulationBPSKRadioButton.CheckedChanged += new System.EventHandler(this.ModulationBPSKRadioButton_CheckedChanged);
            // 
            // _modulationQPSKRadioButton
            // 
            this._modulationQPSKRadioButton.AutoSize = true;
            this._modulationQPSKRadioButton.Location = new System.Drawing.Point(5, 41);
            this._modulationQPSKRadioButton.Name = "_modulationQPSKRadioButton";
            this._modulationQPSKRadioButton.Size = new System.Drawing.Size(54, 17);
            this._modulationQPSKRadioButton.TabIndex = 9;
            this._modulationQPSKRadioButton.TabStop = true;
            this._modulationQPSKRadioButton.Text = "QPSK";
            this._modulationQPSKRadioButton.UseVisualStyleBackColor = true;
            this._modulationQPSKRadioButton.CheckedChanged += new System.EventHandler(this.ModulationQPSKRadioButton_CheckedChanged);
            // 
            // _FECCheckBox
            // 
            this._FECCheckBox.AutoSize = true;
            this._FECCheckBox.Location = new System.Drawing.Point(205, 54);
            this._FECCheckBox.Name = "_FECCheckBox";
            this._FECCheckBox.Size = new System.Drawing.Size(46, 17);
            this._FECCheckBox.TabIndex = 11;
            this._FECCheckBox.Text = "FEC";
            this._FECCheckBox.UseVisualStyleBackColor = true;
            this._FECCheckBox.CheckedChanged += new System.EventHandler(this.FECCheckBox_CheckedChanged);
            // 
            // _resetButton
            // 
            this._resetButton.Location = new System.Drawing.Point(204, 72);
            this._resetButton.Margin = new System.Windows.Forms.Padding(2);
            this._resetButton.Name = "_resetButton";
            this._resetButton.Size = new System.Drawing.Size(47, 22);
            this._resetButton.TabIndex = 12;
            this._resetButton.Text = "Reset";
            this._resetButton.UseVisualStyleBackColor = true;
            this._resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // _sendHexTextBox
            // 
            this._sendHexTextBox.Location = new System.Drawing.Point(11, 169);
            this._sendHexTextBox.Margin = new System.Windows.Forms.Padding(2);
            this._sendHexTextBox.Multiline = true;
            this._sendHexTextBox.Name = "_sendHexTextBox";
            this._sendHexTextBox.Size = new System.Drawing.Size(330, 45);
            this._sendHexTextBox.TabIndex = 16;
            this._sendHexTextBox.TextChanged += new System.EventHandler(this.SendHexTextBox_TextChanged);
            // 
            // _sendHexLabel
            // 
            this._sendHexLabel.AutoSize = true;
            this._sendHexLabel.Location = new System.Drawing.Point(8, 154);
            this._sendHexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._sendHexLabel.Name = "_sendHexLabel";
            this._sendHexLabel.Size = new System.Drawing.Size(63, 13);
            this._sendHexLabel.TabIndex = 15;
            this._sendHexLabel.Text = "Send (HEX)";
            // 
            // _receiveLastTextBox
            // 
            this._receiveLastTextBox.Location = new System.Drawing.Point(11, 261);
            this._receiveLastTextBox.Margin = new System.Windows.Forms.Padding(2);
            this._receiveLastTextBox.Multiline = true;
            this._receiveLastTextBox.Name = "_receiveLastTextBox";
            this._receiveLastTextBox.ReadOnly = true;
            this._receiveLastTextBox.Size = new System.Drawing.Size(330, 21);
            this._receiveLastTextBox.TabIndex = 19;
            // 
            // _receiveLastLabel
            // 
            this._receiveLastLabel.AutoSize = true;
            this._receiveLastLabel.Location = new System.Drawing.Point(9, 246);
            this._receiveLastLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._receiveLastLabel.Name = "_receiveLastLabel";
            this._receiveLastLabel.Size = new System.Drawing.Size(70, 13);
            this._receiveLastLabel.TabIndex = 18;
            this._receiveLastLabel.Text = "Last Receive";
            // 
            // _receiveClearButton
            // 
            this._receiveClearButton.Location = new System.Drawing.Point(221, 429);
            this._receiveClearButton.Margin = new System.Windows.Forms.Padding(2);
            this._receiveClearButton.Name = "_receiveClearButton";
            this._receiveClearButton.Size = new System.Drawing.Size(58, 22);
            this._receiveClearButton.TabIndex = 22;
            this._receiveClearButton.Text = "Clear";
            this._receiveClearButton.UseVisualStyleBackColor = true;
            this._receiveClearButton.Click += new System.EventHandler(this._receiveClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 459);
            this.Controls.Add(this._receiveClearButton);
            this.Controls.Add(this._receiveLastLabel);
            this.Controls.Add(this._receiveLastTextBox);
            this.Controls.Add(this._sendHexLabel);
            this.Controls.Add(this._sendHexTextBox);
            this.Controls.Add(this._resetButton);
            this.Controls.Add(this._FECCheckBox);
            this.Controls.Add(this._modulationGroupBox);
            this.Controls.Add(this._modeGroupBox);
            this.Controls.Add(this._receiveLabel);
            this.Controls.Add(this._sendAnsiiLabel);
            this.Controls.Add(this._receiveButton);
            this.Controls.Add(this._receiveHistoryTextBox);
            this.Controls.Add(this._sendButton);
            this.Controls.Add(this._sendAsciiTextBox);
            this.Controls.Add(this._closeButton);
            this.Controls.Add(this._openButton);
            this.Controls.Add(this._listOfPortsComboBox);
            this.Controls.Add(this._portLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Terminal";
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
        private System.Windows.Forms.TextBox _receiveHistoryTextBox;
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
        private System.Windows.Forms.Button _resetButton;
        private System.Windows.Forms.TextBox _sendHexTextBox;
        private System.Windows.Forms.Label _sendHexLabel;
        private System.Windows.Forms.TextBox _receiveLastTextBox;
        private System.Windows.Forms.Label _receiveLastLabel;
        private System.Windows.Forms.Button _receiveClearButton;
    }
}

