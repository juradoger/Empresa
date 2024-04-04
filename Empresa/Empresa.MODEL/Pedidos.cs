using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.MODEL
{
    public class Pedidos
    {
        public int IdPedido { get; set; }   
        public int Idcliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }  
    }
}
