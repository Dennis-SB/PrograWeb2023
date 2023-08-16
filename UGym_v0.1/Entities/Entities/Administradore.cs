using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Administradore
    {
        public int AdminId { get; set; }
        public string NombreCompleto { get; set; } = null!;
        public string CorreoElectronico { get; set; } = null!;
        public int RolId { get; set; }
    }
}
