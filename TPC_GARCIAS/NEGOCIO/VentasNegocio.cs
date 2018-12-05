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
        /*
        public IList<COMPRAS> listar()
        {
            //conexion
            SqlConnection conexion = new SqlConnection();
            //sentencia
            SqlCommand comando = new SqlCommand();
            //objeto de recepcion
            SqlDataReader lector;
            //lista
            IList<COMPRAS> lista = new List<COMPRAS>();
            COMPRAS aux;

            try
            {
                conexion.ConnectionString = @"data source =.\SQLEXPRESS; initial catalog= GARCIAS_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT *, P.NOMBRE FROM COMPRAS AS C left join PROVEEDORES AS P ON P.IDPROV = C.CODPROV";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new COMPRAS();
                                        
                    aux.intIDCompra = (int)lector["IDCOMPRA"];
                    aux.intIDProv = (int)lector["CODPROV"];
                    aux.strNomProv = (string)lector["NOMBRE"];
                    aux.datFechaCompra = (DateTime)lector["FECHA_COMPRA"];
                    aux.dmlValorCompra = decimal.Round((decimal)lector["VALOR_COMPRA"],2);
                    aux.strNroFactura = (string)lector["NRODOCUMENTO"];

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
                //lector.Close();
                lector = null;
                conexion.Close();
            }


        }
        */

        public IList<DetalleVentas> listar()
        {

            clsConexiones conexion = new clsConexiones();
                        
            IList<DetalleVentas> lista = new List<DetalleVentas>();
            DetalleVentas aux;

            try
            {
                conexion = new clsConexiones();
                conexion.setearConsulta("SELECT V.IDVENTA,V.FECHA_VTA,V.IDCLIENTE,V.NROFACTURA,V.FECHA_FACTURA,V.MONTO_FACTURA,P.IDPEDIDO FROM VENTAS AS V INNER JOIN CLIENTES AS C ON C.IDCLIENTE = V.IDCLIENTE INNER JOIN PEDIDOS AS P ON P.IDVENTA = V.IDVENTA");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                
                while (conexion.Lector.Read())
                {
                    aux = new DetalleVentas();

                    aux.intIDVenta = conexion.Lector.GetInt32(0);
                    aux.datFechaVta = conexion.Lector.GetDateTime(1);
                    aux.intIDCliente = conexion.Lector.GetInt32(2);

                    //if (string.IsNullOrEmpty(conexion.Lector.GetString(3)))
                    //    aux.strNroFact = null;
                    //else
                    //    aux.strNroFact = conexion.Lector.GetString(3);

                    if (Convert.IsDBNull(conexion.Lector.GetDateTime(4)))
                        aux.datFechaFact = null;
                    else
                        aux.datFechaFact = conexion.Lector.GetDateTime(4);

                    if (Convert.IsDBNull(conexion.Lector.GetDecimal(5)))
                        aux.decMontoFac = null;
                    else
                        aux.decMontoFac = conexion.Lector.GetDecimal(5);

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
    }
}
