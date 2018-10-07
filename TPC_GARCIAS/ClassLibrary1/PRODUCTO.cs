using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class PRODUCTO
    {
        public string strDescripcion { get; set; }
        public float fltValorUltMov { get; set; }
        public DateTime datFechaUltMov { get; set; }
        public DateTime datFechaAlta { get; set; }
        public DateTime datFechaBaja { get; set; }
        public DateTime datUltMod { get; set; }
        public int intStatus { get; set; }
    }
}
