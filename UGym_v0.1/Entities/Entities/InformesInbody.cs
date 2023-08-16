using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class InformesInbody
    {
        public int InformeInbodyId { get; set; }
        public string EnlaceInformeInbody { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public int SocioId { get; set; }
        public int EmpleadoId { get; set; }
    }
}
