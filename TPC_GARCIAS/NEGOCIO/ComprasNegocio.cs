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
                    aux.decValorCompra = decimal.Round((decimal)conexion.Lector["VALOR_COMPRA"], 2);
                    aux.strNroRemito = (string)conexion.Lector["NRODOCUMENTO"];

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

        public void cargarCompra(COMPRAS comp)
        {
            clsConexiones conexion = new clsConexiones();
            try
            {

                conexion.setearConsulta("INSERT INTO COMPRAS (CODPROV,FECHA_COMPRA,VALOR_COMPRA,NRODOCUMENTO) VALUES  (@COD,@FECHA,@VALOR,@REMITO)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@COD", comp.intIDProv);
                conexion.Comando.Parameters.AddWithValue("@FECHA", DateTime.Now);
                conexion.Comando.Parameters.AddWithValue("@VALOR", comp.decValorCompra);
                conexion.Comando.Parameters.AddWithValue("@REMITO", comp.strNroRemito);

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

        public void cargarRemito(IList<DetalleCompras> listaC)
        {
            clsConexiones conexion = new clsConexiones();
            int aux;
            aux = consultarC();
            try
            {
                conexion.abrirConexion();

                foreach (DetalleCompras det in listaC)
                {
                    conexion.setearConsulta("INSERT INTO DETALLE_COMPRAS (NROREMITO,FECHAREMITO,IDCOMPRA,INSUMO,CANTIDAD) VALUES (@NRO,@FECHAR,@IDCOMP,@INS,@CANT)");
                    conexion.Comando.Parameters.Clear();
                    conexion.Comando.Parameters.AddWithValue("@NRO", det.strNroRemito);
                    conexion.Comando.Parameters.AddWithValue("@FECHAR", DateTime.Now);
                    conexion.Comando.Parameters.AddWithValue("@IDCOMP", aux);
                    conexion.Comando.Parameters.AddWithValue("@INS", det.intIdInsumo);
                    conexion.Comando.Parameters.AddWithValue("@CANT", det.intCantidad);
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

        public int consultarC()
        {
            int aux;
            clsConexiones conexion = new clsConexiones();
            try
            {
                conexion.setearConsulta("SELECT TOP 1 IDCOMPRA from COMPRAS ORDER BY IDCOMPRA DESC");

                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                conexion.Lector.Read();

                aux = (int)conexion.Lector["IDCOMPRA"];

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