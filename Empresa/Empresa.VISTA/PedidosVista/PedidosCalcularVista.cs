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
    public partial class PedidosCalcularVista : Form
    {
        public PedidosCalcularVista()
        {
            InitializeComponent();
        }
        PedidosBss pbss = new PedidosBss();
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idcliente = Convert.ToInt32(textBox1.Text);
            dataGridView2.DataSource = pbss.PedidosConsultaTotalBss(idcliente);
        }

        private void PedidosCalcularVista_Load(object sender, EventArgs e)
        {

        }
    }
}
