using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;
using System.Data.SqlClient;

namespace NEGOCIO
{
    public class ContactosNegocio
    {
        
        public DatosContacto consultar(int id)
        {
            DatosContacto aux;
            clsConexiones conexion = new clsConexiones();
            try
            {
                conexion.setearConsulta("SELECT * from CONTACTOS where IDCONTACTO=@id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                aux = new DatosContacto();

                conexion.Lector.Read();

                aux.intIDContacto = (int)conexion.Lector["IDCONTACTO"];
                aux.strNombre = (string)conexion.Lector["NOMBRE"];
                aux.strEmail = (string)conexion.Lector["EMAIL"];
                aux.intTelefono = (int)conexion.Lector["TELEFONO"];
                aux.strDireccion = (string)conexion.Lector["DIRECCION"];

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

        public int consultarID()
        {
            int aux;
            clsConexiones conexion = new clsConexiones();
            try
            {
                conexion.setearConsulta("SELECT TOP 1 IDCONTACTO from CONTACTOS ORDER BY IDCONTACTO DESC");

                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                conexion.Lector.Read();

                aux = (int)conexion.Lector["IDCONTACTO"];

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


        public void modificar(DatosContacto contacto)
        {
   
            clsConexiones conexion = new clsConexiones();
            try
            {
                conexion.setearConsulta("UPDATE CONTACTOS SET NOMBRE=@NOMBRE, EMAIL=@EMAIL, TELEFONO=@TELEFONO, DIRECCION=@DIRECCION WHERE IDCONTACTO=@ID ");

                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@ID", contacto.intIDContacto);
                conexion.Comando.Parameters.AddWithValue("@NOMBRE", contacto.strNombre);
                conexion.Comando.Parameters.AddWithValue("@EMAIL", contacto.strEmail);
                conexion.Comando.Parameters.AddWithValue("@TELEFONO", contacto.intTelefono);
                conexion.Comando.Parameters.AddWithValue("@DIRECCION", contacto.strDireccion);

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

        public void alta(DatosContacto nuevo)
        {
            clsConexiones conexion = new clsConexiones();

            try
            {
                conexion.setearConsulta("insert into CONTACTOS (NOMBRE, EMAIL, TELEFONO, DIRECCION) values (@NOMBRE, @EMAIL, @TELEFONO, @DIRECCION)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@NOMBRE", nuevo.strNombre);
                conexion.Comando.Parameters.AddWithValue("@EMAIL", nuevo.strEmail);
                conexion.Comando.Parameters.AddWithValue("@TELEFONO", nuevo.intTelefono);
                conexion.Comando.Parameters.AddWithValue("@DIRECCION", nuevo.strDireccion);
   
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
