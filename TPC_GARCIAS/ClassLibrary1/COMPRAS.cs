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
        public string strNomProv { get; set; }
        public DateTime datFechaCompra { get; set; }
        public decimal dmlValorCompra { get; set; }
        public string strNroFactura { get; set; }
    }
}
