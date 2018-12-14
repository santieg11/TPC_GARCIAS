using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;
using System.Data.SqlClient;

namespace NEGOCIO
{
    public class ComprasNegocio
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

        public IList<COMPRAS> listar()
        {

            clsConexiones conexion = new clsConexiones();
                        
            IList<COMPRAS> lista = new List<COMPRAS>();
            COMPRAS aux;

            try
            {
                conexion = new clsConexiones();
                conexion.setearConsulta("SELECT *, P.NOMBRE FROM COMPRAS AS C left join PROVEEDORES AS P ON P.IDPROV = C.CODPROV");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                
                while (conexion.Lector.Read())
                {
                    aux = new COMPRAS();

                    aux.intIDCompra = (int)conexion.Lector["IDCOMPRA"];
                    aux.intIDProv = (int)conexion.Lector["CODPROV"];
                    aux.datFechaCompra = (DateTime)conexion.Lector["FECHA_COMPRA"];
                    aux.dmlValorCompra = decimal.Round((decimal)conexion.Lector["VALOR_COMPRA"], 2);
                    aux.strNroFactura = (string)conexion.Lector["NRODOCUMENTO"];

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
