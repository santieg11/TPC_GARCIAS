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
        DateTime datFechaAlta { get; set; }
        DateTime datFechaBaja { get; set; }
        DateTime datUltMod { get; set; }
        int intStatus { get; set; }
    }
}
