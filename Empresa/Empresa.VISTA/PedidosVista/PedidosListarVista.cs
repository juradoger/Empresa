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
using Empresa.VISTA;
using Empresa.MODEL;
namespace Empresa.VISTA.PedidosVista
{
    public partial class PedidosListarVista : Form
    {
        public PedidosListarVista()
        {
            InitializeComponent();
        }
        PedidosBss pedidos = new PedidosBss();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PedidosListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pedidos.ListarPedidosBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PedidosEliminarVista v_eliminar = new PedidosEliminarVista();   
            if(v_eliminar.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = pedidos.ListarPedidosBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PedidosEditarVista v_eliminar = new PedidosEditarVista();
            if (v_eliminar.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = pedidos.ListarPedidosBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PedidosInsertarVista v_eliminar = new PedidosInsertarVista();
            if (v_eliminar.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = pedidos.ListarPedidosBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PedidosCalcularVista v_eliminar = new PedidosCalcularVista();
            if (v_eliminar.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = pedidos.ListarPedidosBss();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PedidosListarClienteVista v_eliminar = new PedidosListarClienteVista();
            if (v_eliminar.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = pedidos.ListarPedidosBss();
            }
        }
    }
}
