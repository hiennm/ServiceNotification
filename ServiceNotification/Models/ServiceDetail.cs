using System;
using System.Collections.Generic;

namespace ServiceNotification.Models
{
    public partial class ServiceDetail
    {
        public int DetailId { get; set; }
        public int ServiceId { get; set; }
        public string ServiceUser { get; set; }
        public string ServiceUserEmail { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public bool? ExpirationNotice { get; set; }
        public int? RequestId { get; set; }

        public virtual Service Service { get; set; }
    }
}
