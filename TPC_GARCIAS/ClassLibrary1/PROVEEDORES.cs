using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class PROVEEDORES : PERSONA
    {
        int intIDProv { get; set; }
        string strCuit { get; set; }
        int intIdContacto { get; set; }
    }
}
