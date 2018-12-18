using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;
using System.Data.SqlClient;

namespace NEGOCIO
{
    public class PedidosNegocio
    {

        public IList<PedidoVta> listar()
        {

            clsConexiones conexion = new clsConexiones();

            IList<PedidoVta> lista = new List<PedidoVta>();
            PedidoVta aux;

            try
            {
                conexion = new clsConexiones();
                conexion.setearConsulta("SELECT * from PEDIDOS");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new PedidoVta();

                    aux.intNroPedido = conexion.Lector.GetInt32(0);
                    aux.intIDVenta = conexion.Lector.GetInt32(1);
                    aux.datFechaVta = conexion.Lector.GetDateTime(2);
                    aux.datEntregaAcordada = conexion.Lector.GetDateTime(3);
                    if (conexion.Lector["FECHA_ENTREGA_REAL"] == DBNull.Value)
                        aux.datEntregaReal = null;

                    aux.intStatusPedido = conexion.Lector.GetInt32(5);  

                    lista.Add(aux);
                }

                return lista;

            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Lector.Close();
                conexion.cerrarConexion();

            }


        }
    }
}