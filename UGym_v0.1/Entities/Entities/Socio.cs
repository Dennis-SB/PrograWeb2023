using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Socio
    {
        public int SocioId { get; set; }
        public int NumeroSocio { get; set; }
        public string Contraseña { get; set; } = null!;
        public string NombreCompleto { get; set; } = null!;
        public string? Genero { get; set; }
        public int Cedula { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string? Ocupacion { get; set; }
        public string? ConoceGym { get; set; }
        public string? Motivacion { get; set; }
        public string CorreoElectronico { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public int ContactoEmergenciaId { get; set; }
        public int? ExpedienteId { get; set; }
        public int? CodigoQrid { get; set; }
        public int? EmpleadoId { get; set; }
        public int RolId { get; set; }
    }
}
