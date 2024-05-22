using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace practica1
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            InitializeSerialPorts();
        }
        private void InitializeSerialPorts()
        {
            comboBoxPorts.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                comboBoxPorts.Items.Add($"COM{i}");
            }
            comboBoxPorts.SelectedIndex = 0;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            txtBoxMessage.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.Close();
                }

                string selectedPort = comboBoxPorts.SelectedItem.ToString();
                serialPort = new SerialPort(selectedPort, 9600);
                serialPort.Open();
                MessageBox.Show("Conectado al puerto " + selectedPort);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
                MessageBox.Show("Desconectado del puerto " + serialPort.PortName);
            }
            else
            {
                MessageBox.Show("No hay conexión activa para desconectar.");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                string message = txtBoxMessage.Text;
                serialPort.WriteLine(message);
                MessageBox.Show("Mensaje enviado: " + message);
            }
            else
            {
                MessageBox.Show("Por favor, conecta al puerto serial primero.");
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
        private void txtBoxMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
