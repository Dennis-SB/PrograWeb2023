using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class DetalleFactura
    {
        public int CodDetalleFactura { get; set; }
        public int NumFactura { get; set; }
        public int CodProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public virtual Factura NumFacturaNavigation { get; set; } = null!;
    }
}
