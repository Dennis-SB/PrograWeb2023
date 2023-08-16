using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class SociosTipoMembresia
    {
        public int SocioId { get; set; }
        public int TipoMembresiaId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public string? Estado { get; set; }
    }
}
