using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino
{
    public partial class Form1 : Form
    {
        private SerialPort srpArduino;
        public Form1()
        {
            InitializeComponent();
            srpArduino = new SerialPort();
            srpArduino.DataReceived += SrpArduino_DataReceived;
        }

        private void SrpArduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           // txtReceber.Text ==
          throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrPortas.Tick += tmrPortas_Tick;     
            tmrPortas.Enabled = true;
        }

        private void tmrPortas_Tick(object sender, EventArgs e)
        {
           var i = 0;
           var qtdDiferente = false;

            if(cmbPortas.Items.Count == SerialPort.GetPortNames().Length) {

                foreach (var porta in SerialPort.GetPortNames())
                {
                    if (!cmbPortas.Items[i++].Equals(porta))
                    {
                        qtdDiferente |= true;   
                        break;
                        
                    }
                }
            
            }
            else
            
                qtdDiferente = true;
            if (!qtdDiferente)
                return;

            cmbPortas.Items.Clear();

            foreach (var porta in SerialPort.GetPortNames())
            {
                cmbPortas.Items.Add(porta);
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (!srpArduino.IsOpen)
            {
                try
                {
                    srpArduino.PortName = cmbPortas.SelectedText;
                    srpArduino.Open();
                    btnConectar.Text = "Desconectar";
                    cmbPortas.Enabled = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else

                try
                {
                    srpArduino.Close();
                    btnConectar.Text = "Conectar";
                    cmbPortas.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
    }
}
