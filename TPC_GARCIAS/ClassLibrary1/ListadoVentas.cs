using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class ListadoVentas
    {
        public int intIDVta { get; set; }
        public DateTime datFechaVta { get; set; }
        public int intIDCliente { get; set; }
        public string strNombreC { get; set; }
        public int intIdPed { get; set; }
        public DateTime datFechaEntrega { get; set; }
        public decimal decValor { get; set; }
    }
}
