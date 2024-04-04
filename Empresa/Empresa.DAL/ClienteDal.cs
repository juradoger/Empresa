using Empresa.DAL;
using Empresa.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClientesDal()
        {
            string consulta = "select * from cliente";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public Cliente ObtenerIdCliente(int id)
        {
            string consulta = "select * from cliente where idcliente="+id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "tabla");
            Cliente cliente = new Cliente();
            if (tabla.Rows.Count > 0)
            {
                cliente.IdCliente=Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                cliente.Nombre = tabla.Rows[0]["nombre"].ToString();
                cliente.Apellido = tabla.Rows[0]["apellido"].ToString();
                cliente.Correo = tabla.Rows[0]["correo"].ToString();
                cliente.Telefono = tabla.Rows[0]["telefono"].ToString();
                cliente.Direccion = tabla.Rows[0]["direccion"].ToString();
            }
            return cliente;
        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "INSERT INTO CLIENTE VALUES(" +
                              "'" + cliente.Nombre + "' ," +
                              " '" + cliente.Apellido + "' ," +
                              " '" + cliente.Correo + "' ," +
                              " '" + cliente.Telefono + "' ," +
                              " '" + cliente.Direccion + "' )";
            Conexion.Ejecutar(consulta);
        }
        public void EliminarClienteDal(int id)
        {
            string consulta = "DELETE  FROM CLIENTE WHERE IDCLIENTE = " + id;
            Conexion.Ejecutar(consulta);
        }
        public void EditarClienteDal(Cliente c)
        {
            string consulta = "UPDATE CLIENTE SET NOMBRE = '" + c.Nombre + "' ," +
                                                     "APELLIDO = '" + c.Apellido + "' ," +
                                                     "CORREO = '" + c.Correo + "'," +
                                                     "TELEFONO = '" + c.Telefono + "' , " +
                                                     "DIRECCION = '" + c.Direccion + "' " +
                              "WHERE IDCLIENTE =" + c.IdCliente;
            Conexion.Ejecutar(consulta);
        }
    }
}
