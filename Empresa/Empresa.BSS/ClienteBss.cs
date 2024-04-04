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
    public class ClienteBss
    {
        ClienteDal dal = new ClienteDal();
        public DataTable ListarClienteBss()
        {
            return dal.ListarClientesDal();
        }
        public void InsertarClienteBss(Cliente cliente)
        {
            dal.InsertarClienteDal(cliente);
        }
        public void EliminarClienteBss(int id)
        {
            dal.EliminarClienteDal(id);
        }
        public void EditarClienteBss(Cliente cliente)
        {
            dal.EditarClienteDal(cliente);
        }
        public Cliente ObtenerIdClienteBss(int id)
        {
            return dal.ObtenerIdCliente(id);
        }
    }
}
