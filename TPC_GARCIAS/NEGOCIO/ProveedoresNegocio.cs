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

        /*
        public void modificar(PROVEEDORES propiedad)
        {
            clsConexiones conexion;
            try
            {
                conexion = new clsConexiones();
                conexion.setearConsulta("update PROVEEDORES set DescripcionGeneral = @descripcion, SuperficieCubierta = @supCubierta, SuperficieDescubierta = @supDescubierta Where IdPropiedad = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@descripcion", propiedad.DescripcionGeneral);
                conexion.Comando.Parameters.AddWithValue("@supCubierta", propiedad.SuperficieCubierta);
                conexion.Comando.Parameters.AddWithValue("@supDescubierta", propiedad.SuperficieDescubierta);
                conexion.Comando.Parameters.AddWithValue("@id", propiedad.Id);

                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        */
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

        /*
        public void eliminarLogico(int id)
        {
            clsConexiones conexion;
            try
            {
                conexion = new clsConexiones();
                conexion.setearConsulta("Update Propiedades Set Activo = 0 Where IdPropiedad=@id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        */
    }
}
