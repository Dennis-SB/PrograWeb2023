using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Expediente
    {
        public int ExpedienteId { get; set; }
        public string CirugiasTipo { get; set; } = null!;
        public int CirugiasCantidad { get; set; }
        public string? CirugiasDetalle { get; set; }
        public string? FarmacosTipo { get; set; }
        public int? FarmacosCantidad { get; set; }
        public string? FarmacosAlergia { get; set; }
        public string? EnfermedadCardiaca { get; set; }
        public string? DoloresPecho { get; set; }
        public int? HorasSentado { get; set; }
        public int? CicloSueño { get; set; }
        public int? EstresUltimoMes { get; set; }
        public int? MotivacionEntrenar { get; set; }
        public string? DificuladPerderGrasa { get; set; }
        public string? NivelEnergiaUltimoMes { get; set; }
        public int? PasosPorDia { get; set; }
        public string? EjercicioTresMeses { get; set; }
        public string? MotivoAsistencia { get; set; }
        public string? AutoRegulacion { get; set; }
        public int? Concentracion { get; set; }
        public int? Alimentacion { get; set; }
        public string? AlimentacionEstres { get; set; }
    }
}
