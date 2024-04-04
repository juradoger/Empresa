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
namespace Empresa.VISTA.PedidosVista
{
    public partial class PedidosEliminarVista : Form
    {
        public PedidosEliminarVista()
        {
            InitializeComponent();
        }
        Cliente c = new Cliente();
        Pedidos p = new Pedidos();
        PedidosBss bssp = new PedidosBss();
        ClienteBss cbss = new ClienteBss();
        private void button3_Click(object sender, EventArgs e)
        {
            p = bssp.ObtenerIdPedidoBss(Convert.ToInt32(textBox2.Text));
            Cliente cliente = cbss.ObtenerIdClienteBss(Convert.ToInt32(textBox2.Text));
            textBox1.Text = cliente.Nombre + " " + cliente.Apellido;
            dateTimePicker1.Value = p.Fecha;
            textBox3.Text = p.Total.ToString(); 
            textBox4.Text = p.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Convert.ToInt32(textBox2.Text));
            DialogResult mensaje = MessageBox.Show("¿Está seguro de eliminarlo?", "Eliminando...", MessageBoxButtons.YesNo);
            if(mensaje == DialogResult.Yes)
            {
                bssp.EliminarPedidosBss(id);
                MessageBox.Show("Eliminado");
            }
        }
    }
}
