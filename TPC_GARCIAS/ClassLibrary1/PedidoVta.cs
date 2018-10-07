using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class PedidoVta : VENTAS
    {
        public int intNroPedido { get; set; }
        public DateTime datEntregaAcordada { get; set; }
        public DateTime datEntregaReal { get; set; }
        public int intCodInsumo { get; set; }
        public int intCantInsumo { get; set; }
        public float fltValorVta { get; set; }
        public int intStatusPedido { get; set; }
        public string strNroFactura { get; set; }
        public DateTime datFechaFactura { get; set; }
        public float fltMontoFactura { get; set; }
    }
}
