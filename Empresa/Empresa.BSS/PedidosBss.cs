using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.DAL;
using Empresa.MODEL;

namespace Empresa.BSS
{
    public class PedidosBss
    {
        PedidosDal dal = new PedidosDal();
        public DataTable ListarPedidosBss()
        {
           return dal.ListarPedidosDal();
        }
        public DataTable ListarPedidosClienteBss(int id)
        {
            return dal.ListarPedidosClientesDal(id);
        }
        public DataTable PedidosConsultaTotalBss(int id)
        {
            return dal.CalcularTotalClienteDal(id);
        }
        public void InsertarPedidosBss(Pedidos pedido)
        {
            dal.InsertarPedidosDal(pedido);
        }
        public void EditarPedidosBss(Pedidos pedido)
        {
            dal.EditarPedidosDal(pedido);
        }
        public void EliminarPedidosBss(int id)
        {
            dal.EliminarPedidosDal(id);
        }
        public Pedidos ObtenerIdPedidoBss(int id)
        {
            return dal.ObtenerIdPedidoDal(id);
        }
    }
}
