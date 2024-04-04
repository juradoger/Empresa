using Empresa.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.VISTA;
using System.Windows.Forms;

namespace Empresa.VISTA.ClienteVista
{
    public partial class ClienteListarVista : Form
    {
        public ClienteListarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();  
        private void button3_Click(object sender, EventArgs e)
        {
            ClienteInsertarVista ventana3 = new ClienteInsertarVista();
            if (ventana3.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClienteBss();
            }

        }

        private void ClienteListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteEditarVista ventana2 = new ClienteEditarVista();
            if (ventana2.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClienteEliminarVista ventana1 = new ClienteEliminarVista();
            if (ventana1.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
