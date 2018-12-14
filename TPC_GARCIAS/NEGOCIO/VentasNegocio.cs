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

        public IList<DetalleVentas> listar()
        {

            clsConexiones conexion = new clsConexiones();

            IList<DetalleVentas> lista = new List<DetalleVentas>();
            DetalleVentas aux;

            try
            {
                conexion = new clsConexiones();
                conexion.setearConsulta("SELECT V.IDVENTA,V.FECHA_VTA,V.IDCLIENTE,P.IDPEDIDO FROM VENTAS AS V INNER JOIN CLIENTES AS C ON C.IDCLIENTE = V.IDCLIENTE INNER JOIN PEDIDOS AS P ON P.IDVENTA = V.IDVENTA");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new DetalleVentas();

                    aux.intIDVenta = conexion.Lector.GetInt32(0);
                    aux.datFechaVta = conexion.Lector.GetDateTime(1);
                    aux.intIDCliente = conexion.Lector.GetInt32(2);
                    aux.intIdPed = conexion.Lector.GetInt32(6);


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
                conexion.setearConsulta("INSERT INTO VENTAS (FECHA_VTA,IDCLIENTE) VALUES (@FECHA,@ID)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@FECHA", DateTime.Now);
                conexion.Comando.Parameters.AddWithValue("@ID",vta.intIDCliente);

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
                foreach (INGRESOS ing in list)
                    {

                    conexion.setearConsulta("INSERT INTO DETALLE_VENTAS (IDVENTA,PRODUCTO,CANTIDAD,VALOR) VALUES (@IDVTA,@PROD,@CANT,@VAL)");
                    conexion.Comando.Parameters.Clear();
                    conexion.Comando.Parameters.AddWithValue("@IDVTA", id);
                    conexion.Comando.Parameters.AddWithValue("@PROD", ing.intcod);
                    conexion.Comando.Parameters.AddWithValue("@CANT", ing.intcantidad);
                    conexion.Comando.Parameters.AddWithValue("@VAL", ing.decValorIng);

                    conexion.abrirConexion();
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
