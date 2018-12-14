using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class DetalleCompras : COMPRAS
    {
        public int intIdInsumo { get; set; }
        public string strDesc { get; set; }
        public int intCantidad { get; set; }
        public decimal decValor { get; set; }
    }
}
