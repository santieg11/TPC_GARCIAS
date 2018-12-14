using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class MATERIAL
    {
        public string strDescripcion { get; set; }
        public decimal decValor { get; set; }
        public Nullable<decimal> decValorUltMov { get; set; }
        public Nullable<DateTime> datFechaUltMov { get; set; }
        public DateTime datFechaAlta { get; set; }
        public Nullable<DateTime> datFechaBaja { get; set; }
        public Nullable<DateTime> datUltMod { get; set; }
        public int intStatus { get; set; }
    }
}
