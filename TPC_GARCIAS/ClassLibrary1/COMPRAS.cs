using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class COMPRAS
    {
        public int intIDCompra { get; set; }
        public int intIDProv { get; set; }
        public string strNombreProv { get; set; }
        public DateTime datFechaCompra { get; set; }
        public decimal decValorCompra { get; set; }
        public string strNroRemito { get; set; }
    }
}
