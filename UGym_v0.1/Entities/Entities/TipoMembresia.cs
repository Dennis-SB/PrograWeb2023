using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class TipoMembresia
    {
        public int TipoMembresiaId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Tipo { get; set; } = null!;
    }
}
