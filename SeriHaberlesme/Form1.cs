using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SeriHaberlesme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void COMPortlariListele()
        {
            string[] myPort;

            myPort = System.IO.Ports.SerialPort.GetPortNames();
            comboBoxCOMPorts.Items.AddRange(myPort);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            COMPortlariListele();
            comboBoxVeriGonderKarakteri.SelectedIndex = 0;
            
            
        }

        delegate void GelenVerileriGuncelleCallback(string veri);

        private void GelenVerileriGuncelle(string veri)
        {
            if (this.textBoxGelenVeri.InvokeRequired)
            {
                GelenVerileriGuncelleCallback d = new GelenVerileriGuncelleCallback(GelenVerileriGuncelle);
                this.Invoke(d, new object[] { veri });
            }
            else
            {
                this.textBoxGelenVeri.AppendText(veri);
            }
        }

        private void buttonSerialPortGonder_Click(object sender, EventArgs e)
        {
            byte[] veri = new byte[2] {0x0D,0x0A};
            
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write(textBoxSerialPortGonderilecekVeri.Text);
                switch(comboBoxVeriGonderKarakteri.SelectedIndex)
                {
                    case 1: // CR
                        serialPort1.Write(veri, 0, 1);
                        break;
                    case 2:// NL
                        serialPort1.Write(veri, 1, 1);
                        break;
                    case 3://CR & NL
                        serialPort1.Write(veri, 0, 2);
                        break;
                }               
            }
        }

        private void buttonSerialPortBaglanti_Click(object sender, EventArgs e)
        {
            if (comboBoxCOMPorts.SelectedIndex < 0)
            {
                MessageBox.Show("COM port bulunamadi");
                return;
            }

            if (comboBoxSerialPortBaudRate.SelectedIndex < 0)
            {
                MessageBox.Show("Bağlantı hızı seçiniz");
                return;
            }

            try
            {
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.PortName = comboBoxCOMPorts.SelectedItem.ToString();
                    serialPort1.BaudRate = Convert.ToInt32(comboBoxSerialPortBaudRate.Text);
                    serialPort1.Open();
                    buttonSerialPortBaglanti.Text = "BAĞLANTI KES";
                    
                    timerSerialPort.Enabled = true;
                }
                else
                {
                    timerSerialPort.Enabled = false;
                    serialPort1.Close();
                    buttonSerialPortBaglanti.Text = "BAĞLANTI AÇ";
                }
            }
            catch
            {
                MessageBox.Show("Bağlantı açılamadı!");
            }
        }

        private void timerSerialPort_Tick(object sender, EventArgs e)
        {
            if (serialPort1.BytesToRead > 0)
            {
                GelenVerileriGuncelle(serialPort1.ReadExisting());
               
            }
        }

        private void comboBoxVeriGonderKarakteri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

