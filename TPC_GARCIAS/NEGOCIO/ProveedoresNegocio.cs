using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;
using System.Data.SqlClient;

namespace NEGOCIO
{
    public class ProveedoresNegocio
    {
        
        public IList<PROVEEDORES> listar()
        {

            clsConexiones conexion = new clsConexiones();
                        
            IList<PROVEEDORES> lista = new List<PROVEEDORES>();
            PROVEEDORES aux;

            try
            {
                conexion = new clsConexiones();
                conexion.setearConsulta("SELECT *,c.NOMBRE from PROVEEDORES as P left join CONTACTOS as C ON C.IDCONTACTO = P.IDCONTACTO");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                
                while (conexion.Lector.Read())
                {
                    aux = new PROVEEDORES();
                                          
                    aux.intIDProv = (int)conexion.Lector["IDPROV"];
                    aux.strNombre = (string) conexion.Lector["NOMBRE"];
                    aux.strCuit = (string)conexion.Lector["CUIT"];
                    aux.intIdContacto = (int)conexion.Lector["IDCONTACTO"];
                    aux.datFechaAlta = (DateTime) conexion.Lector["FECHA_ALTA"];

                    if (conexion.Lector["FECHA_BAJA"] == DBNull.Value)
                        aux.datFechaBaja = null;
                    else
                        aux.datFechaBaja = (DateTime)conexion.Lector["FECHA_BAJA"];

                    if (conexion.Lector["ULT_MOD"] == DBNull.Value)
                        aux.datUltMod = null;
                    else
                        aux.datUltMod = (DateTime)conexion.Lector["ULT_MOD"];

                    aux.intStatus = (int)conexion.Lector["STATUS"];
                    
             
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
