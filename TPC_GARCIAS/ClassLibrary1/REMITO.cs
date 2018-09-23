using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class REMITO : COMPRAS
    {
        string strNroRemito { get; set; }
        int intIDCompra { get; set; }
        int intCodInsumo { get; set; }
        int intCantidad { get; set; }
    }
}
