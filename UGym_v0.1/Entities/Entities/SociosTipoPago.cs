using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class SociosTipoPago
    {
        public int SocioId { get; set; }
        public int PagoId { get; set; }
        public DateTime FechaPago { get; set; }
    }
}
