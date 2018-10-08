using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class DatosContacto : PERSONA
    {
        public int intIDContacto { get; set; }
        public string strEmail { get; set; }
        public int intTelefono { get; set; }
        public string strDireccion { get; set; }
    }
}
