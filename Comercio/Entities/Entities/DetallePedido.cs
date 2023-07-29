using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class DetallePedido
    {
        public int CodDetallePedido { get; set; }
        public int? NumPedido { get; set; }
        public int? CodProducto { get; set; }
        public int Cantidad { get; set; }

        public virtual Producto? CodProductoNavigation { get; set; }
        public virtual Pedido? NumPedidoNavigation { get; set; }
    }
}
