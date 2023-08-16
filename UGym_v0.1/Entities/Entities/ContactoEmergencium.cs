using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class ContactoEmergencium
    {
        public int ContactoEmergenciaId { get; set; }
        public string NombreCompleto { get; set; } = null!;
        public int Telefono { get; set; }
    }
}
