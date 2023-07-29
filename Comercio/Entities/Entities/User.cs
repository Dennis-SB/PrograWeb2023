using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class User
    {
        public User()
        {
            RoleRoles = new HashSet<Role>();
        }

        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Nombre { get; set; }
        public string? Password { get; set; }

        public virtual ICollection<Role> RoleRoles { get; set; }
    }
}
