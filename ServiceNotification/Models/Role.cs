using System;
using System.Collections.Generic;

namespace ServiceNotification.Models
{
    public partial class Role
    {
        public Role()
        {
            UserRole = new HashSet<UserRole>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool? Enabled { get; set; }

        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
