using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class InformesEvaluacion
    {
        public int InformeEvaluacionId { get; set; }
        public string EnlaceInformeEvaluacion { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public int SocioId { get; set; }
        public int EmpleadoId { get; set; }
    }
}
