using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class PlanAlimentacion
    {
        public int PlanAlimenticioId { get; set; }
        public string PlanAlimenticio { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public int SocioId { get; set; }
        public int EmpleadoId { get; set; }
    }
}
