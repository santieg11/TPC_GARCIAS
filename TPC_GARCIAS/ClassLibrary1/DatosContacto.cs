using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class DatosContacto : PERSONA
    {
        int intIDContacto { get; set; }
        string strEmail { get; set; }
        int intTelefono { get; set; }
        string strDireccion { get; set; }
        int intClienteProveedor { get; set; }
    }
}
