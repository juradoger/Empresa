using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empresa.BSS;
using Empresa.MODEL;

namespace Empresa.VISTA.ClienteVista
{
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = textBox2.Text;
            cliente.Apellido = textBox3.Text;
            cliente.Correo = textBox4.Text;
            cliente.Telefono = textBox5.Text;
            cliente.Direccion = textBox6.Text;
            bss.InsertarClienteBss(cliente);
            MessageBox.Show("Cliente Registrado");

        }
    }
}
