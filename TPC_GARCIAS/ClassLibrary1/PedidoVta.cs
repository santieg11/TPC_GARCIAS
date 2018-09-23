using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class PedidoVta : VENTAS
    {
        int intNroPedido { get; set; }
        DateTime datEntregaAcordada { get; set; }
        DateTime datEntregaReal { get; set; }
        int intCodInsumo { get; set; }
        int intCantInsumo { get; set; }
        float fltValorVta { get; set; }
        int intStatus { get; set; }
        string strNroFactura { get; set; }
        DateTime datFechaFactura { get; set; }
        float fltMontoFactura { get; set; }
    }
}
