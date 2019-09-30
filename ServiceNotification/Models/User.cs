using System;
using System.Collections.Generic;

namespace ServiceNotification.Models
{
    public partial class User
    {
        public User()
        {
            UserRole = new HashSet<UserRole>();
        }

        public int UserId { get; set; }
        public string UserAccount { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool? Enabled { get; set; }

        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
