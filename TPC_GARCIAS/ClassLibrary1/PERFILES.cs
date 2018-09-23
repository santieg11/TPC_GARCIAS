using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class PERFILES
    {
        int intIDPerfil { get; set; }
        string strDescripcion { get; set; }
        int intIdModulos { get; set; }
        DateTime datFechaAlta { get; set; }
        DateTime datFechaBaja { get; set; }
        DateTime datUltMod { get; set; }
    }
}
