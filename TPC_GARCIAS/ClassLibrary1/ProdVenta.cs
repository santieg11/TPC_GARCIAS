using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class ProdVenta : PRODUCTO
    {
        int intIDProd { get; set; }
        int intGanancia { get; set; }
        int intCodInsumos { get; set; }
    }
}
