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
    public partial class PedidosEditarVista : Form
    {
        public PedidosEditarVista()
        {
            InitializeComponent();
        }
        Pedidos p = new Pedidos();
        PedidosBss pbss = new PedidosBss();
        private void button1_Click(object sender, EventArgs e)
        {
            p.Fecha = Convert.ToDateTime(dateTimePicker1.Value);
            p.Total = Convert.ToDecimal(textBox3.Text);
            p.Estado = textBox4.Text;
            pbss.EditarPedidosBss(p);
            MessageBox.Show("Datos actualizados exitosamente...");
        }

        private void PedidosEditarVista_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            p = pbss.ObtenerIdPedidoBss(Convert.ToInt32(textBox1.Text));
            dateTimePicker1.Value = p.Fecha;
            textBox3.Text = p.Total.ToString();
            textBox4.Text = p.Estado;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
