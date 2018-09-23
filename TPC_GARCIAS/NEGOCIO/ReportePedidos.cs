using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;
using System.Data.SqlClient;

namespace NEGOCIO
{
    public class ReportePedidos
    {
        //Metodo que devuelve una lista de ambientes.
        //si le paso un idPropiedad, busco  por propiedad
        //si no se lo paso, toma cero, en ese caso busco todo
        public List<PedidoVta> listar(int intNroPedido = 0)
        {
            //lista a ser devuelta.
            List<PedidoVta> lista = new List<PedidoVta>();
            //creo la conexion directamente con la cadena de conexion
            SqlConnection conexion = new SqlConnection(@"data source =.\SQLEXPRESS;initial catalog=GARCIAS_DB; integrated security=sspi");
            //creo el comando directamente con el command text y la conexion. Todo pasado por constructor.
            SqlCommand comando = new SqlCommand("select * from PEDIDOS", conexion);
            //lector para los datos leidos.
            SqlDataReader lector;
            try
            {
                //asigno tipo de comando a utilizar. TEXT para una consulta simple embebida.
                comando.CommandType = System.Data.CommandType.Text;

                //Si me vino un idPropiedad informado en el metodo
                //agrego un where a la consulta original.
                if (intNroPedido > 0)
                    comando.CommandText = comando.CommandText + " Where NroPedido=" + intNroPedido.ToString();

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    //creo un ambiente al que directamente por constructor
                    //le estoy pasando los datos del lector, de la consulta SQL de arriba.
                    PedidoVta aux = new PedidoVta();
                    lista.Add(aux);
                }

                //return de la lista que creé arriba, antes del TRY.
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}

