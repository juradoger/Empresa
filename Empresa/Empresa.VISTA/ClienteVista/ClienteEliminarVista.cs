using Empresa.DAL;
using Empresa.MODEL;
using Empresa.BSS;
using Empresa.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa.VISTA.ClienteVista
{
    public partial class ClienteEliminarVista : Form
    {
        Cliente cliente = new Cliente();
        ClienteBss cbssp = new ClienteBss();
        public ClienteEliminarVista()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int IdPersonaSelecciionada = Convert.ToInt32(textBox1.Text);
            DialogResult result = MessageBox.Show("¿Esta seguro de eliminar esta persona?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cbssp.EliminarClienteBss(IdPersonaSelecciionada);
                MessageBox.Show("Eliminado Exitosamente");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cliente = cbssp.ObtenerIdClienteBss(Convert.ToInt32(textBox1.Text));            
            textBox2.Text = cliente.Nombre.ToString();
            textBox3.Text = cliente.Apellido.ToString();
            textBox4.Text = cliente.Correo.ToString();
            textBox5.Text = cliente.Telefono.ToString();
            textBox6.Text = cliente.Direccion.ToString();
           
  
        }
    }
}
