using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnesLayerDml
{
    public class Pedido
    {
        public int PedidoID { get; set; }
        public DateTime FechaPedido { get; set; }
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }
    }
}
