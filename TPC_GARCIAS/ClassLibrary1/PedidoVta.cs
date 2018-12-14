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
        public Nullable<DateTime> datEntregaReal { get; set; }
        public int intStatusPedido { get; set; }
    }
}
