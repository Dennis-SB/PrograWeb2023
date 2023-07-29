using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Factura
    {
        public Factura()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }

        public int NumFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public decimal? Total { get; set; }
        public decimal? Descuento { get; set; }

        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
    }
}
