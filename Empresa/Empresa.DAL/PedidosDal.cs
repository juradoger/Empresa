using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.DAL;
using Empresa.MODEL;

namespace Empresa.DAL
{
    public class PedidosDal
    {
        public DataTable ListarPedidosDal()
        {
            string consulta = "SELECT * FROM PEDIDOS";
            return Conexion.EjecutarDataTabla(consulta, "tabla");

        }
        public DataTable ListarPedidosClientesDal(int id)
        {
            string consulta = "SELECT P.IDPEDIDO, C.NOMBRE, P.FECHA, P.TOTAL, P.ESTADO\r\nFROM PEDIDOS P INNER JOIN CLIENTE C ON P.IDCLIENTE = C.IDCLIENTE\r\nWHERE P.IDCLIENTE = " + id;
            return Conexion.EjecutarDataTabla(consulta, "tabla");
        }
        public DataTable CalcularTotalClienteDal(int id)
        {
            string consulta = "SELECT C.NOMBRE, SUM(TOTAL) AS MONTO_TOTAL, COUNT(*) AS TOTAL_PEDIDOS\r\nFROM PEDIDOS P INNER JOIN CLIENTE C ON P.IDCLIENTE = C.IDCLIENTE\r\nWHERE P.IDCLIENTE = " + id + "\r\nGROUP BY C.NOMBRE";
            return Conexion.EjecutarDataTabla(consulta, "tabla");
        }
        public void InsertarPedidosDal(Pedidos pedidos)
        {
            string consulta = "INSERT INTO PEDIDOS VALUES (" +
                                                    "" + pedidos.Idcliente + " ," +
                                                    "'" + pedidos.Fecha + "' ," +
                                                    "" + pedidos.Total + "," +
                                                    "'" + pedidos.Estado + "' )";
            Conexion.Ejecutar(consulta);
        }
        public Pedidos ObtenerIdPedidoDal(int id)
        {
            string consulta = "SELECT * FROM PEDIDOS WHERE IDPEDIDO = " + id;
            DataTable fila = Conexion.EjecutarDataTabla(consulta, "tabla");
            Pedidos pedidos = new Pedidos();
            if(fila.Rows.Count > 0)
            {
                pedidos.IdPedido = Convert.ToInt32(fila.Rows[0]["idpedido"]);
                pedidos.Idcliente = Convert.ToInt32(fila.Rows[0]["idcliente"]);
                pedidos.Fecha = Convert.ToDateTime(fila.Rows[0]["fecha"]);
                pedidos.Total = Convert.ToDecimal(fila.Rows[0]["total"]);
                pedidos.Estado = fila.Rows[0]["estado"].ToString();
                
            }
            return pedidos;
        }
        public void EditarPedidosDal(Pedidos pedido)
        {
            string consulta = "UPDATE PEDIDOS SET FECHA = '" + pedido.Fecha + "' ," +
                                                  "TOTAL = " + pedido.Total + " , " +
                                                  "ESTADO = '" + pedido.Estado + "' " +
                                                  "WHERE IDPEDIDO = " + pedido.IdPedido;
            Conexion.Ejecutar(consulta);

        }
        public void EliminarPedidosDal(int id)
        {
            string consulta = "DELETE FROM PEDIDOS WHERE IDPEDIDO = " + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
