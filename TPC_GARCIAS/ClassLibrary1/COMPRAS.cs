using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class COMPRAS
    {
        int intIDCompra { get; set; }
        int intIDProv { get; set; }
        DateTime datFechaCompra { get; set; }
        string strNroFactura { get; set; }
        float fltValorCompra { get; set; }
    }
}
