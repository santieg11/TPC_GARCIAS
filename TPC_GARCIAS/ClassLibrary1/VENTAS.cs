using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class VENTAS
    {
        public int intIDVenta { get; set; }
        public DateTime datFechaVta { get; set; }
        public int intIDCliente { get; set; }
        public int intStatus { get; set; }
        public string strNroFact { get; set; }
        public Nullable<DateTime> datFechaFact { get; set; }
        public Nullable<decimal> decMontoFac { get; set; }

    }
}
