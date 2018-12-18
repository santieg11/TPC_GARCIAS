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
                conexion.setearConsulta("SELECT * from PROVEEDORES");
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

        public void modificar(PROVEEDORES prov)
        {

            clsConexiones conexion = new clsConexiones();
            try
            {
                conexion.setearConsulta("UPDATE PROVEEDORES SET NOMBRE=@NOMBRE, CUIT=@CUIT, ULT_MOD=@MOD WHERE IDPROV=@ID ");

                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@ID", prov.intIDProv);
                conexion.Comando.Parameters.AddWithValue("@NOMBRE", prov.strNombre);
                conexion.Comando.Parameters.AddWithValue("@CUIT", prov.strCuit);
                conexion.Comando.Parameters.AddWithValue("@MOD", prov.datUltMod);

                conexion.abrirConexion();
                conexion.ejecutarAccion();



            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                conexion.cerrarConexion();


            }
        }

        public void alta(PROVEEDORES nuevo)
        {
            clsConexiones conexion = new clsConexiones();
            try
            {
                conexion.setearConsulta("insert into PROVEEDORES (NOMBRE, CUIT, IDCONTACTO, FECHA_ALTA, FECHA_BAJA, ULT_MOD, STATUS) values (@NOMBRE, @CUIT, @IDCONTACTO, @FECHA_ALTA, @FECHA_BAJA, @ULT_MOD, 1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@NOMBRE", nuevo.strNombre);
                conexion.Comando.Parameters.AddWithValue("@CUIT", nuevo.strCuit);
                conexion.Comando.Parameters.AddWithValue("@IDCONTACTO", nuevo.intIdContacto);
                conexion.Comando.Parameters.AddWithValue("@FECHA_ALTA", DateTime.Now);
                conexion.Comando.Parameters.AddWithValue("@FECHA_BAJA", DBNull.Value);
                conexion.Comando.Parameters.AddWithValue("@ULT_MOD", DateTime.Now);
                
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

        
        public void eliminarLogico(int id)
        {
            clsConexiones conexion;
            try
            {
                conexion = new clsConexiones();
                conexion.setearConsulta("Update PROVEEDORES Set STATUS = 0, FECHA_BAJA=@BAJA Where IDPROV=@id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                conexion.Comando.Parameters.AddWithValue("@baja", DateTime.Now);
                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void habilitarlogico(int id)
        {
            clsConexiones conexion;
            try
            {
                conexion = new clsConexiones();
                conexion.setearConsulta("Update PROVEEDORES Set STATUS = 1, FECHA_BAJA=@BAJA, ULT_MOD=@MOD Where IDPROV=@id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                conexion.Comando.Parameters.AddWithValue("@BAJA", DBNull.Value);
                conexion.Comando.Parameters.AddWithValue("@MOD", DateTime.Now);

                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public PROVEEDORES ConsultarProv(int id)
        {
            PROVEEDORES aux;
            clsConexiones conexion = new clsConexiones();
            try
            {
                conexion.setearConsulta("SELECT IDPROV, NOMBRE, CUIT, IDCONTACTO from PROVEEDORES where IDPROV=@id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                aux = new PROVEEDORES();

                conexion.Lector.Read();

                aux.intIDProv = (int)conexion.Lector["IDPROV"];
                aux.strNombre = (string)conexion.Lector["NOMBRE"];
                aux.strCuit = (string)conexion.Lector["CUIT"];
                aux.intIdContacto = (int)conexion.Lector["IDCONTACTO"];

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
