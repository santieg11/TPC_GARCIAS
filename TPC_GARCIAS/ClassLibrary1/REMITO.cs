using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class REMITO : COMPRAS
    {
        public string strNroRemito { get; set; }
        public int intCodInsumo { get; set; }
        public int intCantidad { get; set; }
    }
}
