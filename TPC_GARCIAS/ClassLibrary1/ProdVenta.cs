using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class ProdVenta : PRODUCTO
    {
        public int intIDProd { get; set; }
        public int intGanancia { get; set; }
        public int intCodInsumos { get; set; }
    }
}
