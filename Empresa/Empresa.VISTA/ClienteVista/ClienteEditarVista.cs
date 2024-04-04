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
using Empresa.DAL;

namespace Empresa.VISTA.ClienteVista
{
    public partial class ClienteEditarVista : Form
    {
        Cliente cliente = new Cliente();
        ClienteBss cbss = new ClienteBss();
        public ClienteEditarVista()
        {
            InitializeComponent();
        }

        private void ClienteEditarVista_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente.Nombre = textBox2.Text;
            cliente.Apellido = textBox3.Text;
            cliente.Correo = textBox4.Text;
            cliente.Telefono = textBox5.Text;
            cliente.Direccion = textBox6.Text;

            cbss.EditarClienteBss(cliente);
            MessageBox.Show("Datos Actualizados");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cliente = cbss.ObtenerIdClienteBss(Convert.ToInt32(textBox1.Text));
            textBox2.Text = cliente.Nombre.ToString();
            textBox3.Text = cliente.Apellido.ToString();
            textBox4.Text = cliente.Correo.ToString();
            textBox5.Text = cliente.Telefono.ToString();
            textBox6.Text = cliente.Direccion.ToString();

        }
    }
}
