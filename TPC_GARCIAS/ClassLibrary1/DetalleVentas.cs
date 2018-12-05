using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class DetalleVentas : VENTAS
    {
        public int intIdProd { get; set; }
        public int intCantidad { get; set; }
        public decimal decValor { get; set; }
        public int intIdPed { get; set; }
    }
}
