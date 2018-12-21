using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;
using System.Data.SqlClient;



namespace NEGOCIO
{
    public class UsuarioNegocio
    {

        public bool validarUsuario(Usuario usuario)
        {
            clsConexiones conexion;
            try
            {
                conexion = new clsConexiones();
                conexion.setearConsulta("select ID, NOMBRE, PW from USUARIOS Where NOMBRE=@usuario and PW=@clave");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@usuario", usuario.strNombreUsuario);
                conexion.Comando.Parameters.AddWithValue("@clave", usuario.strClave);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                if (conexion.Lector.Read())
                {
                    usuario.intId = (int)conexion.Lector["ID"];
                    usuario.strNombreUsuario = (string)conexion.Lector["NOMBRE"];
                    usuario.strClave = (string)conexion.Lector["PW"];


                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int agregar(Usuario usuario)
        {
            clsConexiones conexion;
            try
            {
                conexion = new clsConexiones();
                conexion.setearConsulta("INSERT INTO USUARIOS output inserted.ID VALUES (@Usuario, @Clave)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@Usuario", usuario.strNombreUsuario);
                conexion.Comando.Parameters.AddWithValue("@Clave", usuario.strClave);


                conexion.abrirConexion();
                return conexion.ejecutarAccionReturn();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool existeUsuario(Usuario usuario)
        {
            clsConexiones conexion;
            try
            {
                conexion = new clsConexiones();
                conexion.setearConsulta("select ID, NOMBRE from USUARIOS Where NOMBRE=@usuario");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@usuario", usuario.strNombreUsuario);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                if (conexion.Lector.Read())
                {
                    usuario.intId = (int)conexion.Lector["ID"];
                    usuario.strNombreUsuario = (string)conexion.Lector["NOMBRE"];



                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}