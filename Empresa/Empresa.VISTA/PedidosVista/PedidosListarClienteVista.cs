using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empresa.MODEL;
using Empresa.BSS;

namespace Empresa.VISTA.PedidosVista
{
    public partial class PedidosListarClienteVista : Form
    {
        public PedidosListarClienteVista()
        {
            InitializeComponent();
        }
        PedidosBss bss = new PedidosBss();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idcliente = Convert.ToInt32(textBox1.Text);
            dataGridView1.DataSource = bss.ListarPedidosClienteBss(idcliente);
        }

        private void PedidosListarClienteVista_Load(object sender, EventArgs e)
        {
        }
    }
}
