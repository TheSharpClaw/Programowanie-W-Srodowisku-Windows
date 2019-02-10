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
            this.label1 = new System.Windows.Forms.Label();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Label();
            this.Receive = new System.Windows.Forms.Label();
            this.clearScrollback = new System.Windows.Forms.Button();
            this.sendReset = new System.Windows.Forms.Button();
            this.DL_Button = new System.Windows.Forms.RadioButton();
            this.PH_button = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EPSK_button = new System.Windows.Forms.RadioButton();
            this.QSK_button = new System.Windows.Forms.RadioButton();
            this.BPSK_button = new System.Windows.Forms.RadioButton();
            this.FEC_checkbox = new System.Windows.Forms.CheckBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtMessageASCII = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(68, 23);
            this.cboPorts.Margin = new System.Windows.Forms.Padding(2);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(121, 21);
            this.cboPorts.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(223, 19);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 27);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(327, 19);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 27);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(92, 50);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(304, 92);
            this.txtMessage.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(293, 249);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(79, 31);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send Frame";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(293, 441);
            this.btnReceive.Margin = new System.Windows.Forms.Padding(2);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(79, 31);
            this.btnReceive.TabIndex = 7;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(68, 343);
            this.txtReceive.Margin = new System.Windows.Forms.Padding(2);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ReadOnly = true;
            this.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceive.Size = new System.Drawing.Size(328, 92);
            this.txtReceive.TabIndex = 6;
            // 
            // Send
            // 
            this.Send.AutoSize = true;
            this.Send.Location = new System.Drawing.Point(11, 89);
            this.Send.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(81, 13);
            this.Send.TabIndex = 8;
            this.Send.Text = "Message(HEX):";
            // 
            // Receive
            // 
            this.Receive.AutoSize = true;
            this.Receive.Location = new System.Drawing.Point(19, 382);
            this.Receive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Receive.Name = "Receive";
            this.Receive.Size = new System.Drawing.Size(45, 13);
            this.Receive.TabIndex = 9;
            this.Receive.Text = "Answer:";
            // 
            // clearScrollback
            // 
            this.clearScrollback.Location = new System.Drawing.Point(166, 440);
            this.clearScrollback.Name = "clearScrollback";
            this.clearScrollback.Size = new System.Drawing.Size(112, 31);
            this.clearScrollback.TabIndex = 11;
            this.clearScrollback.Text = "Clear Scrollback";
            this.clearScrollback.UseVisualStyleBackColor = true;
            this.clearScrollback.Click += new System.EventHandler(this.clearScrollback_Click);
            // 
            // sendReset
            // 
            this.sendReset.Location = new System.Drawing.Point(198, 249);
            this.sendReset.Name = "sendReset";
            this.sendReset.Size = new System.Drawing.Size(80, 31);
            this.sendReset.TabIndex = 12;
            this.sendReset.Text = "Send Reset";
            this.sendReset.UseVisualStyleBackColor = true;
            this.sendReset.Click += new System.EventHandler(this.sendReset_Click);
            // 
            // DL_Button
            // 
            this.DL_Button.AutoSize = true;
            this.DL_Button.Location = new System.Drawing.Point(0, 19);
            this.DL_Button.Name = "DL_Button";
            this.DL_Button.Size = new System.Drawing.Size(39, 17);
            this.DL_Button.TabIndex = 13;
            this.DL_Button.TabStop = true;
            this.DL_Button.Text = "DL";
            this.DL_Button.UseVisualStyleBackColor = true;
            this.DL_Button.CheckedChanged += new System.EventHandler(this.DL_Button_CheckedChanged);
            // 
            // PH_button
            // 
            this.PH_button.AutoSize = true;
            this.PH_button.Location = new System.Drawing.Point(0, 37);
            this.PH_button.Name = "PH_button";
            this.PH_button.Size = new System.Drawing.Size(47, 17);
            this.PH_button.TabIndex = 14;
            this.PH_button.TabStop = true;
            this.PH_button.Text = "PHY";
            this.PH_button.UseVisualStyleBackColor = true;
            this.PH_button.CheckedChanged += new System.EventHandler(this.PH_button_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DL_Button);
            this.groupBox1.Controls.Add(this.PH_button);
            this.groupBox1.Location = new System.Drawing.Point(22, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(52, 60);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EPSK_button);
            this.groupBox2.Controls.Add(this.QSK_button);
            this.groupBox2.Controls.Add(this.BPSK_button);
            this.groupBox2.Location = new System.Drawing.Point(86, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(89, 86);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modulation";
            // 
            // EPSK_button
            // 
            this.EPSK_button.AutoSize = true;
            this.EPSK_button.Location = new System.Drawing.Point(6, 60);
            this.EPSK_button.Name = "EPSK_button";
            this.EPSK_button.Size = new System.Drawing.Size(52, 17);
            this.EPSK_button.TabIndex = 19;
            this.EPSK_button.TabStop = true;
            this.EPSK_button.Text = "8PSK";
            this.EPSK_button.UseVisualStyleBackColor = true;
            this.EPSK_button.CheckedChanged += new System.EventHandler(this.EPSK_button_CheckedChanged);
            // 
            // QSK_button
            // 
            this.QSK_button.AutoSize = true;
            this.QSK_button.Location = new System.Drawing.Point(6, 37);
            this.QSK_button.Name = "QSK_button";
            this.QSK_button.Size = new System.Drawing.Size(47, 17);
            this.QSK_button.TabIndex = 19;
            this.QSK_button.TabStop = true;
            this.QSK_button.Text = "QSK";
            this.QSK_button.UseVisualStyleBackColor = true;
            this.QSK_button.CheckedChanged += new System.EventHandler(this.QSK_button_CheckedChanged);
            // 
            // BPSK_button
            // 
            this.BPSK_button.AutoSize = true;
            this.BPSK_button.Location = new System.Drawing.Point(6, 14);
            this.BPSK_button.Name = "BPSK_button";
            this.BPSK_button.Size = new System.Drawing.Size(53, 17);
            this.BPSK_button.TabIndex = 18;
            this.BPSK_button.TabStop = true;
            this.BPSK_button.Text = "BPSK";
            this.BPSK_button.UseVisualStyleBackColor = true;
            this.BPSK_button.CheckedChanged += new System.EventHandler(this.BPSK_button_CheckedChanged);
            // 
            // FEC_checkbox
            // 
            this.FEC_checkbox.AutoSize = true;
            this.FEC_checkbox.Location = new System.Drawing.Point(23, 318);
            this.FEC_checkbox.Name = "FEC_checkbox";
            this.FEC_checkbox.Size = new System.Drawing.Size(46, 17);
            this.FEC_checkbox.TabIndex = 18;
            this.FEC_checkbox.Text = "FEC";
            this.FEC_checkbox.UseVisualStyleBackColor = true;
            this.FEC_checkbox.CheckedChanged += new System.EventHandler(this.FEC_checkbox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Message(ASCII):";
            // 
            // txtMessageASCII
            // 
            this.txtMessageASCII.Location = new System.Drawing.Point(92, 152);
            this.txtMessageASCII.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessageASCII.Multiline = true;
            this.txtMessageASCII.Name = "txtMessageASCII";
            this.txtMessageASCII.Size = new System.Drawing.Size(304, 92);
            this.txtMessageASCII.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 483);
            this.Controls.Add(this.txtMessageASCII);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FEC_checkbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sendReset);
            this.Controls.Add(this.clearScrollback);
            this.Controls.Add(this.Receive);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Label Send;
        private System.Windows.Forms.Label Receive;
        private System.Windows.Forms.Button clearScrollback;
        private System.Windows.Forms.Button sendReset;
        private System.Windows.Forms.RadioButton DL_Button;
        private System.Windows.Forms.RadioButton PH_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton EPSK_button;
        private System.Windows.Forms.RadioButton QSK_button;
        private System.Windows.Forms.RadioButton BPSK_button;
        private System.Windows.Forms.CheckBox FEC_checkbox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMessageASCII;
    }
}

