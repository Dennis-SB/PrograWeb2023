using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class TipoPago
    {
        public int PagoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public decimal Monto { get; set; }
    }
}
