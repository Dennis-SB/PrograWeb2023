using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class InformesTerapium
    {
        public int InformeTerapiaId { get; set; }
        public string EnlaceInformeTerapia { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public int SocioId { get; set; }
        public int EmpleadoId { get; set; }
    }
}
