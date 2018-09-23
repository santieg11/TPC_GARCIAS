using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class VENTAS
    {
        int intIDVenta { get; set; }
        DateTime datFechaVta { get; set; }
        int intIDCliente { get; set; }
        int intIDProducto { get; set; }
        int intCantVta { get; set; }
        int intStatus { get; set; }
        int intIDUsuario { get; set; }
    }
}
