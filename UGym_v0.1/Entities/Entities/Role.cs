using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Role
    {
        public int RolesId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
    }
}
