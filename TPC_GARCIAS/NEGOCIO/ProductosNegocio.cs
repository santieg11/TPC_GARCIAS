using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;
using System.Data.SqlClient;

namespace NEGOCIO
{
    public class ProductosNegocio
    {
        
        public IList<PRODUCTOS> listar()
        {

            clsConexiones conexion = new clsConexiones();
                        
            IList<PRODUCTOS> lista = new List<PRODUCTOS>();
            PRODUCTOS aux;

            try
            {
                conexion = new clsConexiones();
                conexion.setearConsulta("SELECT * from PRODUCTOS");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                
                while (conexion.Lector.Read())
                {
                    aux = new PRODUCTOS();
                                          
                    aux.intCodProd = (int)conexion.Lector["IDPROD"];
                    aux.strDescripcion = (string) conexion.Lector["DESCRIPCION"];
                    aux.decValor = (decimal)conexion.Lector["VALOR"];
                    
                    if (conexion.Lector["FECHA_ULT_VTA"] == DBNull.Value)
                        aux.datFechaBaja = null;

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

        public void modificar(PRODUCTOS prod)
        {

            clsConexiones conexion = new clsConexiones();
            try
            {
                conexion.setearConsulta("UPDATE PRODUCTOS SET DESCRIPCION=@DESC, VALOR=@VAL, ULT_MOD=@MOD WHERE IDPROD=@ID");

                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@ID", prod.intCodProd);
                conexion.Comando.Parameters.AddWithValue("@DESC", prod.strDescripcion);
                conexion.Comando.Parameters.AddWithValue("@MOD", DateTime.Now);
                conexion.Comando.Parameters.AddWithValue("@VAL", prod.decValor);

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

        public void alta(PRODUCTOS nuevo)
        {
            clsConexiones conexion = new clsConexiones();
            try
            {
                conexion.setearConsulta("insert into PRODUCTOS (DESCRIPCION, VALOR, VALOR_ULT_VTA, FECHA_ULT_VTA, FECHA_ALTA, FECHA_BAJA, ULT_MOD, STATUS) values (@DESC, @GAN, @VAL, @VAL_ULT_V, @F_ULT_V, @FECHA_ALTA, @FECHA_BAJA, @ULT_MOD, 1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@DESC", nuevo.strDescripcion);
                conexion.Comando.Parameters.AddWithValue("@VAL", nuevo.decValor);
                conexion.Comando.Parameters.AddWithValue("@VAL_ULT_V", 0);
                conexion.Comando.Parameters.AddWithValue("@F_ULT_V", DBNull.Value);
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
                conexion.setearConsulta("Update PRODUCTOS Set STATUS = 0, FECHA_BAJA=@BAJA Where IDPROD=@id");
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
                conexion.setearConsulta("Update PRODUCTOS Set STATUS = 1, FECHA_BAJA=@BAJA, ULT_MOD=@MOD Where IDPROD=@id");
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

        public PRODUCTOS consultar(int id)
        {
            PRODUCTOS aux;
            clsConexiones conexion = new clsConexiones();
            try
            {
                conexion.setearConsulta("SELECT * from PRODUCTOS where IDPROD=@id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                aux = new PRODUCTOS();

                conexion.Lector.Read();

                aux.intCodProd = (int)conexion.Lector["IDPROD"];
                aux.strDescripcion = (string)conexion.Lector["DESCRIPCION"];
                aux.decValor = (decimal)conexion.Lector["VALOR"];
                aux.decValorUltMov = (decimal)conexion.Lector["VALOR_ULT_VTA"];
                aux.datFechaUltMov = (DateTime)conexion.Lector["FECHA_ULT_VTA"];
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
