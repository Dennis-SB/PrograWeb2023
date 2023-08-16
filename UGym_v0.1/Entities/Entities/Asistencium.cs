using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Asistencium
    {
        public int AsistenciaId { get; set; }
        public DateTime FechaAsistencia { get; set; }
        public TimeSpan HoraAsistencia { get; set; }
        public int SocioId { get; set; }
    }
}
