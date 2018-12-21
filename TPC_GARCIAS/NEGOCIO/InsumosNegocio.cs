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
                    aux.strDescripcion = (string)conexion.Lector["DESCRIPCION"];
                    aux.decValor = (decimal)conexion.Lector["VALOR"];

                    if (conexion.Lector["FECHA_ULT_COMPRA"] == DBNull.Value)
                        aux.datFechaBaja = null;

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

        public void modificar(INSUMOS insu)
        {

            clsConexiones conexion = new clsConexiones();
            try
            {
                conexion.setearConsulta("UPDATE INSUMOS SET DESCRIPCION=@DESC, ULT_MOD=@MOD, VALOR=@VAL WHERE IDINSUMO=@ID");

                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@ID", insu.intCodInsumo);
                conexion.Comando.Parameters.AddWithValue("@DESC", insu.strDescripcion);
                conexion.Comando.Parameters.AddWithValue("@MOD", DateTime.Now);
                conexion.Comando.Parameters.AddWithValue("@VAL", insu.decValor);

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
                conexion.setearConsulta("insert into INSUMOS (DESCRIPCION, VALOR, FECHA_ULT_COMPRA, FECHA_ALTA, FECHA_BAJA, ULT_MOD, STATUS) values (@DESC, @VAL, @F_ULT_C, @FECHA_ALTA, @FECHA_BAJA, @ULT_MOD, 1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@DESC", nuevo.strDescripcion);
                conexion.Comando.Parameters.AddWithValue("@VAL", nuevo.decValor);
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
                aux.decValor = (decimal)conexion.Lector["VALOR"];
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

        public IList<ListadoStock> listaS()
        {

            clsConexiones conexion = new clsConexiones();

            IList<ListadoStock> lista = new List<ListadoStock>();
            ListadoStock aux;

            try
            {
                conexion = new clsConexiones();
                conexion.setearConsulta("SELECT * FROM STOCK");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new ListadoStock();

                    aux.intIDMATERIAL = conexion.Lector.GetInt32(0);
                    aux.strDESCRIPCION = conexion.Lector.GetString(1);
                    aux.intCANTIDAD = conexion.Lector.GetInt32(2);

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

        public void altaIPed(IList<InsumosPedidos> Listaped)
        {
            IList<InsumosPedidos> check = new List<InsumosPedidos>();
            foreach(InsumosPedidos insu in Listaped)
            {
                check = listarIP(insu.intCodP);
            }
            


            clsConexiones conexion = new clsConexiones();
            try
            {
                conexion.abrirConexion();

                foreach (InsumosPedidos ped in Listaped)
                {
                    foreach(InsumosPedidos insuP in check)
                    {
                        if (insuP.intCodP == ped.intCodP)
                        {
                            conexion.setearConsulta("UPDATE DETALLE_PEDIDO SET CANTIDAD=@CANT WHERE IDPEDIDO=@IDP AND IDINSUMO=@IDI");
                        }
                        else
                        {
                            conexion.setearConsulta("insert into DETALLE_PEDIDO (IDPEDIDO, IDINSUMO, CANTIDAD) values (@IDP, @IDI, @CANT)");
                        }
                    }
                    conexion.Comando.Parameters.Clear();
                    conexion.Comando.Parameters.AddWithValue("@IDP", ped.intCodP);
                    conexion.Comando.Parameters.AddWithValue("@IDI", ped.intCodI);
                    conexion.Comando.Parameters.AddWithValue("@CANT", ped.intCant);
                    conexion.ejecutarAccion();

                    conexion.setearConsulta("UPDATE STOCK SET CANTIDAD=@CANT WHERE IDMATERIAL = @IDM");
                    conexion.Comando.Parameters.Clear();
                    conexion.Comando.Parameters.AddWithValue("@IDM", ped.intCodI);
                    conexion.Comando.Parameters.AddWithValue("@CANT", (-1 * ped.intCant));
                    conexion.ejecutarAccion();
                }



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

        public IList<InsumosPedidos> listarIP(int id)
        {

            clsConexiones conexion = new clsConexiones();

            IList<InsumosPedidos> lista = new List<InsumosPedidos>();
            InsumosPedidos aux;

            try
            {
                conexion = new clsConexiones();
                conexion.setearConsulta("SELECT * from DETALLE_PEDIDO WHERE IDPEDIDO = @ID");
                conexion.Comando.Parameters.AddWithValue("@ID", id);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new InsumosPedidos();

                    aux.intCodP = conexion.Lector.GetInt32(0);
                    aux.intCodI = conexion.Lector.GetInt32(1);
                    aux.intCant = conexion.Lector.GetInt32(2);

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