using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Producto
    {
        public Producto()
        {
            DetallePedidos = new HashSet<DetallePedido>();
        }

        public int CodProducto { get; set; }
        public string NombreProducto { get; set; } = null!;
        public int? CodProveedor { get; set; }
        public decimal? Precio { get; set; }

        public virtual Proveedore? CodProveedorNavigation { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
