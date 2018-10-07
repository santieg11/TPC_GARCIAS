using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class PERSONA
    {
        public string strNombre { get; set; }
        public string strCuit { get; set; }
        public int intIdContacto { get; set; }
        public DateTime datFechaAlta { get; set; }
        public Nullable<DateTime> datFechaBaja { get; set; }
        public Nullable<DateTime> datUltMod { get; set; }
        public int intStatus { get; set; }
    }
}
