using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Empleado
    {
        public int EmpleadoId { get; set; }
        public int NumeroEmpleado { get; set; }
        public string Contraseña { get; set; } = null!;
        public string NombreCompleto { get; set; } = null!;
        public DateTime? FechaNacimiento { get; set; }
        public string? Genero { get; set; }
        public string CorreoElectronico { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public int Telefono { get; set; }
        public int? ContactoEmergenciaId { get; set; }
        public int RolId { get; set; }
    }
}
