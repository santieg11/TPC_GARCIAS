using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;
using System.Data.SqlClient;

namespace NEGOCIO
{
    public class InsumosNegocio
    {
        
        public IList<INSUMOS> listar()
        {

            clsConexiones conexion = new clsConexiones();
                        
            IList<INSUMOS> lista = new List<INSUMOS>();
            INSUMOS aux;

            try
            {
                conexion = new clsConexiones();
                conexion.setearConsulta("SELECT * from INSUMOS");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                
                while (conexion.Lector.Read())
                {
                    aux = new INSUMOS();
                                          
                    aux.intCodInsumo = (int)conexion.Lector["IDINSUMO"];
                    aux.strDescripcion = (string) conexion.Lector["DESCRIPCION"];
                    aux.decValorUltMov = (decimal)conexion.Lector["VALOR_ULT_COMPRA"];
                    
                    if (conexion.Lector["FECHA_ULT_COMPRA"] == DBNull.Value)
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

        public void modificar(INSUMOS insu)
        {

            clsConexiones conexion = new clsConexiones();
            try
            {
                conexion.setearConsulta("UPDATE INSUMOS SET DESCRIPCION=@DESC, ULT_MOD=@MOD WHERE IDINSUMO=@ID");

                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@ID", insu.intCodInsumo);
                conexion.Comando.Parameters.AddWithValue("@DESC", insu.strDescripcion);
                conexion.Comando.Parameters.AddWithValue("@MOD", insu.datUltMod);

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

        public void alta(INSUMOS nuevo)
        {
            clsConexiones conexion = new clsConexiones();
            try
            {
                conexion.setearConsulta("insert into INSUMOS (DESCRIPCION, VALOR_ULT_COMPRA, FECHA_ULT_COMPRA, FECHA_ALTA, FECHA_BAJA, ULT_MOD, STATUS) values (@DESC, @VAL_ULT_C, @F_ULT_C, @FECHA_ALTA, @FECHA_BAJA, @ULT_MOD, 1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@DESC", nuevo.strDescripcion);
                conexion.Comando.Parameters.AddWithValue("@VAL_ULT_C", 0);
                conexion.Comando.Parameters.AddWithValue("@F_ULT_C", DBNull.Value);
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
                conexion.setearConsulta("Update INSUMOS Set STATUS = 0, FECHA_BAJA=@BAJA Where IDINSUMO=@id");
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
                conexion.setearConsulta("Update INSUMOS Set STATUS = 1, FECHA_BAJA=@BAJA, ULT_MOD=@MOD Where IDINSUMO=@id");
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

        public INSUMOS consultar(int id)
        {
            INSUMOS aux;
            clsConexiones conexion = new clsConexiones();
            try
            {
                conexion.setearConsulta("SELECT * from INSUMOS where IDINSUMO=@id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                aux = new INSUMOS();

                conexion.Lector.Read();

                aux.intCodInsumo = (int)conexion.Lector["IDINSUMO"];
                aux.strDescripcion = (string)conexion.Lector["DESCRIPCION"];
                aux.decValorUltMov = (decimal)conexion.Lector["VALOR_ULT_COMPRA"];
                aux.datFechaUltMov = (DateTime)conexion.Lector["FECHA_ULT_COMPRA"];
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
