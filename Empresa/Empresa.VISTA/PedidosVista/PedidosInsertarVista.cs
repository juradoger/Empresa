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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Empresa.VISTA.PedidosVista
{
    public partial class PedidosInsertarVista : Form
    {
        public PedidosInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdCliente = 0;
        ClienteBss cbss = new ClienteBss();
        PedidosBss bss = new PedidosBss();
        private void button3_Click(object sender, EventArgs e)
        {
            PedidosInsertarVista.IdCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Cliente cliente = cbss.ObtenerIdClienteBss(IdCliente);
            textBox1.Text = cliente.Nombre + " " + cliente.Apellido;
        }

        private void PedidosInsertarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPedidosBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Idcliente = IdCliente;
            pedidos.Fecha = dateTimePicker1.Value;
            pedidos.Total = Convert.ToDecimal(textBox3.Text);
            pedidos.Estado = textBox4.Text.ToString();

            bss.InsertarPedidosBss(pedidos);
            MessageBox.Show("Agregado exitosamente");
        }
    }
}
