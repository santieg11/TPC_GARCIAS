using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class USUARIO : PERSONA
    {
        public int intIDUser { get; set; }
        public string strUsuario { get; set; }
        public string strClave { get; set; }
        public int intBloqueo { get; set; }
    }
}
