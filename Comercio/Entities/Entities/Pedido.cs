using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Pedido
    {
        public Pedido()
        {
            DetallePedidos = new HashSet<DetallePedido>();
        }

        public int NumPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public decimal MontoPedido { get; set; }
        public int? CodProveedor { get; set; }

        public virtual Proveedore? CodProveedorNavigation { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
