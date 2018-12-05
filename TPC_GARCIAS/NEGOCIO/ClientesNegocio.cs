using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;
using System.Data.SqlClient;

namespace NEGOCIO
{
    public class ClientesNegocio
    {

        public IList<CLIENTES> listar()
        {

            clsConexiones conexion = new clsConexiones();

            IList<CLIENTES> lista = new List<CLIENTES>();
            CLIENTES aux;

            try
            {
                conexion = new clsConexiones();
                conexion.setearConsulta("SELECT * from CLIENTES");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new CLIENTES();

                    aux.intIDCliente = (int)conexion.Lector["IDCLIENTE"];
                    aux.strNombre = (string)conexion.Lector["NOMBRE"];
                    aux.strCuit = (string)conexion.Lector["CUIT"];
                    aux.intIdContacto = (int)conexion.Lector["IDCONTACTO"];
                    aux.datFechaAlta = (DateTime)conexion.Lector["FECHA_ALTA"];

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


        public IList<CLIENTES> listar_clientes()
        {

            clsConexiones conexion = new clsConexiones();

            IList<CLIENTES> lista = new List<CLIENTES>();
            CLIENTES aux;

            try
            {
                conexion = new clsConexiones();
                conexion.setearConsulta("SELECT NOMBRE from CLIENTES");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new CLIENTES();

                    aux.strNombre = (string)conexion.Lector["NOMBRE"];

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

        public void modificar(CLIENTES client)
        {

            clsConexiones conexion = new clsConexiones();
            try
            {
                conexion.setearConsulta("UPDATE CLIENTES SET NOMBRE=@NOMBRE, CUIT=@CUIT, ULT_MOD=@MOD WHERE IDCONTACTO=@ID ");

                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@ID", client.intIDCliente);
                conexion.Comando.Parameters.AddWithValue("@NOMBRE", client.strNombre);
                conexion.Comando.Parameters.AddWithValue("@CUIT", client.strCuit);
                conexion.Comando.Parameters.AddWithValue("@MOD", client.datUltMod);

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

        public void alta(CLIENTES nuevo)
        {
            clsConexiones conexion = new clsConexiones();
            try
            {
                conexion.setearConsulta("insert into CLIENTES (NOMBRE, CUIT, IDCONTACTO, FECHA_ALTA, FECHA_BAJA, ULT_MOD, STATUS) values (@NOMBRE, @CUIT, @IDCONTACTO, @FECHA_ALTA, @FECHA_BAJA, @ULT_MOD, 1)");
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
                conexion.setearConsulta("Update CLIENTES Set STATUS = 0, FECHA_BAJA=@BAJA Where IDCLIENTE=@id");
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
                conexion.setearConsulta("Update CLIENTES Set STATUS = 1, FECHA_BAJA=@BAJA, ULT_MOD=@MOD Where IDCLIENTE=@id");
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

        public CLIENTES ConsultarProv(int id)
        {
            CLIENTES aux;
            clsConexiones conexion = new clsConexiones();
            try
            {
                conexion.setearConsulta("SELECT IDCLIENTE, NOMBRE, CUIT, IDCONTACTO from CLIENTES where IDCLIENTE=@id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                aux = new CLIENTES();

                conexion.Lector.Read();

                aux.intIDCliente = (int)conexion.Lector["IDCLIENTE"];
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
