using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class USUARIO : PERSONA
    {
        int intIDUser { get; set; }
        string strUsuario { get; set; }
        string strClave { get; set; }
        int intBloqueo { get; set; }
    }
}
