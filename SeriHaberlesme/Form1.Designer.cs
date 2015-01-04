﻿namespace SeriHaberlesme
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonSerialPortBaglanti = new System.Windows.Forms.Button();
            this.comboBoxCOMPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGelenVeri = new System.Windows.Forms.TextBox();
            this.buttonSerialPortGonder = new System.Windows.Forms.Button();
            this.textBoxSerialPortGonderilecekVeri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timerSerialPort = new System.Windows.Forms.Timer(this.components);
            this.comboBoxSerialPortBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxVeriGonderKarakteri = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSerialPortBaglanti
            // 
            this.buttonSerialPortBaglanti.Location = new System.Drawing.Point(6, 67);
            this.buttonSerialPortBaglanti.Name = "buttonSerialPortBaglanti";
            this.buttonSerialPortBaglanti.Size = new System.Drawing.Size(121, 23);
            this.buttonSerialPortBaglanti.TabIndex = 0;
            this.buttonSerialPortBaglanti.Text = "BAĞLANTI AÇ";
            this.buttonSerialPortBaglanti.UseVisualStyleBackColor = true;
            this.buttonSerialPortBaglanti.Click += new System.EventHandler(this.buttonSerialPortBaglanti_Click);
            // 
            // comboBoxCOMPorts
            // 
            this.comboBoxCOMPorts.FormattingEnabled = true;
            this.comboBoxCOMPorts.Location = new System.Drawing.Point(64, 15);
            this.comboBoxCOMPorts.Name = "comboBoxCOMPorts";
            this.comboBoxCOMPorts.Size = new System.Drawing.Size(63, 21);
            this.comboBoxCOMPorts.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gelen Veriler";
            // 
            // textBoxGelenVeri
            // 
            this.textBoxGelenVeri.Location = new System.Drawing.Point(375, 29);
            this.textBoxGelenVeri.Multiline = true;
            this.textBoxGelenVeri.Name = "textBoxGelenVeri";
            this.textBoxGelenVeri.Size = new System.Drawing.Size(344, 221);
            this.textBoxGelenVeri.TabIndex = 3;
            // 
            // buttonSerialPortGonder
            // 
            this.buttonSerialPortGonder.Location = new System.Drawing.Point(12, 55);
            this.buttonSerialPortGonder.Name = "buttonSerialPortGonder";
            this.buttonSerialPortGonder.Size = new System.Drawing.Size(121, 23);
            this.buttonSerialPortGonder.TabIndex = 4;
            this.buttonSerialPortGonder.Text = "Verileri Gönder";
            this.buttonSerialPortGonder.UseVisualStyleBackColor = true;
            this.buttonSerialPortGonder.Click += new System.EventHandler(this.buttonSerialPortGonder_Click);
            // 
            // textBoxSerialPortGonderilecekVeri
            // 
            this.textBoxSerialPortGonderilecekVeri.Location = new System.Drawing.Point(12, 29);
            this.textBoxSerialPortGonderilecekVeri.Name = "textBoxSerialPortGonderilecekVeri";
            this.textBoxSerialPortGonderilecekVeri.Size = new System.Drawing.Size(355, 20);
            this.textBoxSerialPortGonderilecekVeri.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gönderilecek Veriler";
            // 
            // timerSerialPort
            // 
            this.timerSerialPort.Interval = 200;
            this.timerSerialPort.Tick += new System.EventHandler(this.timerSerialPort_Tick);
            // 
            // comboBoxSerialPortBaudRate
            // 
            this.comboBoxSerialPortBaudRate.FormattingEnabled = true;
            this.comboBoxSerialPortBaudRate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.comboBoxSerialPortBaudRate.Location = new System.Drawing.Point(64, 42);
            this.comboBoxSerialPortBaudRate.Name = "comboBoxSerialPortBaudRate";
            this.comboBoxSerialPortBaudRate.Size = new System.Drawing.Size(63, 21);
            this.comboBoxSerialPortBaudRate.TabIndex = 1;
            // 
            // comboBoxVeriGonderKarakteri
            // 
            this.comboBoxVeriGonderKarakteri.FormattingEnabled = true;
            this.comboBoxVeriGonderKarakteri.Items.AddRange(new object[] {
            "SATIR SONU YOK",
            "CR",
            "NL",
            "CR & NL"});
            this.comboBoxVeriGonderKarakteri.Location = new System.Drawing.Point(140, 55);
            this.comboBoxVeriGonderKarakteri.Name = "comboBoxVeriGonderKarakteri";
            this.comboBoxVeriGonderKarakteri.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVeriGonderKarakteri.TabIndex = 6;
            this.comboBoxVeriGonderKarakteri.SelectedIndexChanged += new System.EventHandler(this.comboBoxVeriGonderKarakteri_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxCOMPorts);
            this.groupBox1.Controls.Add(this.buttonSerialPortBaglanti);
            this.groupBox1.Controls.Add(this.comboBoxSerialPortBaudRate);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SeriPort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "COM Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hız";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxVeriGonderKarakteri);
            this.Controls.Add(this.textBoxSerialPortGonderilecekVeri);
            this.Controls.Add(this.buttonSerialPortGonder);
            this.Controls.Add(this.textBoxGelenVeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonSerialPortBaglanti;
        private System.Windows.Forms.ComboBox comboBoxCOMPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGelenVeri;
        private System.Windows.Forms.Button buttonSerialPortGonder;
        private System.Windows.Forms.TextBox textBoxSerialPortGonderilecekVeri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerSerialPort;
        private System.Windows.Forms.ComboBox comboBoxSerialPortBaudRate;
        private System.Windows.Forms.ComboBox comboBoxVeriGonderKarakteri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

