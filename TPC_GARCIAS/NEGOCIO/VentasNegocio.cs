using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;
using System.Data.SqlClient;

namespace NEGOCIO
{
    public class VentasNegocio
    {

        public IList<ListadoVentas> listar()
        {

            clsConexiones conexion = new clsConexiones();

            IList<ListadoVentas> lista = new List<ListadoVentas>();
            ListadoVentas aux;

            try
            {
                conexion = new clsConexiones();
                conexion.setearConsulta("SELECT V.IDVENTA, V.FECHA_VTA, V.IDCLIENTE, C.NOMBRE, P.IDPEDIDO, P.FECHA_ENTREGA_ACORDADA, V.VALOR FROM VENTAS AS V INNER JOIN CLIENTES AS C ON C.IDCLIENTE = V.IDCLIENTE INNER JOIN PEDIDOS AS P ON P.IDVENTA = V.IDVENTA");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new ListadoVentas();

                    aux.intIDVta = conexion.Lector.GetInt32(0);
                    aux.datFechaVta = conexion.Lector.GetDateTime(1);
                    aux.intIDCliente = conexion.Lector.GetInt32(2);
                    aux.strNombreC = conexion.Lector.GetString(3);
                    aux.intIdPed = conexion.Lector.GetInt32(4);
                    aux.datFechaEntrega = conexion.Lector.GetDateTime(5);
                    aux.decValor = conexion.Lector.GetDecimal(6);


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

        public void grabarVenta(VENTAS vta)
        {
            clsConexiones conexion = new clsConexiones();
            try
            {

                conexion.setearConsulta("INSERT INTO VENTAS (FECHA_VTA,IDCLIENTE,VALOR) VALUES (@FECHA,@ID,@VAL)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@FECHA", DateTime.Now);
                conexion.Comando.Parameters.AddWithValue("@ID",vta.intIDCliente);
                conexion.Comando.Parameters.AddWithValue("@VAL", vta.decValor);

                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                    conexion.cerrarConexion();
            }
        }

        public void grabarDetalleVta(IList<INGRESOS> list)
        {
            int id;

            id = consultarIDVta();
            clsConexiones conexion = new clsConexiones();
            try
            {
                conexion.abrirConexion();
                foreach (INGRESOS ing in list)
                    {

                    conexion.setearConsulta("INSERT INTO DETALLE_VENTAS (IDVENTA,PRODUCTO,CANTIDAD,VALOR) VALUES (@IDVTA,@PROD,@CANT,@VAL)");
                    conexion.Comando.Parameters.Clear();
                    conexion.Comando.Parameters.AddWithValue("@IDVTA", id);
                    conexion.Comando.Parameters.AddWithValue("@PROD", ing.intcod);
                    conexion.Comando.Parameters.AddWithValue("@CANT", ing.intcantidad);
                    conexion.Comando.Parameters.AddWithValue("@VAL", ing.decValorIng);
                    conexion.ejecutarAccion();
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                    conexion.cerrarConexion();
            }
        }

        public void grabarPedido(DateTime entrega)
        {
            int id;

            id = consultarIDVta();
            clsConexiones conexion = new clsConexiones();
            try
            {

                conexion.setearConsulta("INSERT INTO PEDIDOS (IDVENTA,FECHA_PEDIDO,FECHA_ENTREGA_ACORDADA,FECHA_ENTREGA_REAL,[STATUS]) VALUES (@IDVTA,@FECHA,@FECHA_ACO,@FECHA_ENT,1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@IDVTA",id);
                conexion.Comando.Parameters.AddWithValue("@FECHA",DateTime.Now);
                conexion.Comando.Parameters.AddWithValue("@FECHA_ACO",entrega);
                conexion.Comando.Parameters.AddWithValue("@FECHA_ENT",DBNull.Value);

                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                    conexion.cerrarConexion();
            }
        }


        public int consultarIDVta()
        {
            int aux;
            clsConexiones conexion = new clsConexiones();
            try
            {
                conexion.setearConsulta("SELECT TOP 1 IDVENTA from VENTAS ORDER BY IDVENTA DESC");

                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                conexion.Lector.Read();

                aux = (int)conexion.Lector["IDVENTA"];

                return aux;
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
