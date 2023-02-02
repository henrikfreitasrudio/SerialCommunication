namespace SerialCommunication
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
            this.lblPort = new System.Windows.Forms.Label();
            this.cmb_Ports = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSend = new System.Windows.Forms.Label();
            this.txbSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txbReceive = new System.Windows.Forms.TextBox();
            this.lblReceive = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(64, 64);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Port:";
            // 
            // cmb_Ports
            // 
            this.cmb_Ports.FormattingEnabled = true;
            this.cmb_Ports.Location = new System.Drawing.Point(105, 61);
            this.cmb_Ports.Name = "cmb_Ports";
            this.cmb_Ports.Size = new System.Drawing.Size(103, 21);
            this.cmb_Ports.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(238, 59);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(319, 59);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblSend
            // 
            this.lblSend.AutoSize = true;
            this.lblSend.Location = new System.Drawing.Point(58, 129);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(35, 13);
            this.lblSend.TabIndex = 4;
            this.lblSend.Text = "Send:";
            // 
            // txbSend
            // 
            this.txbSend.Location = new System.Drawing.Point(105, 129);
            this.txbSend.Multiline = true;
            this.txbSend.Name = "txbSend";
            this.txbSend.Size = new System.Drawing.Size(428, 107);
            this.txbSend.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(458, 242);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // txbReceive
            // 
            this.txbReceive.Location = new System.Drawing.Point(105, 289);
            this.txbReceive.Multiline = true;
            this.txbReceive.Name = "txbReceive";
            this.txbReceive.Size = new System.Drawing.Size(428, 107);
            this.txbReceive.TabIndex = 7;
            // 
            // lblReceive
            // 
            this.lblReceive.AutoSize = true;
            this.lblReceive.Location = new System.Drawing.Point(43, 289);
            this.lblReceive.Name = "lblReceive";
            this.lblReceive.Size = new System.Drawing.Size(50, 13);
            this.lblReceive.TabIndex = 8;
            this.lblReceive.Text = "Receive:";
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(458, 402);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 9;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 443);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.lblReceive);
            this.Controls.Add(this.txbReceive);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txbSend);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cmb_Ports);
            this.Controls.Add(this.lblPort);
            this.Name = "Form1";
            this.Text = "Serial Communication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ComboBox cmb_Ports;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSend;
        private System.Windows.Forms.TextBox txbSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txbReceive;
        private System.Windows.Forms.Label lblReceive;
        private System.Windows.Forms.Button btnReceive;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

