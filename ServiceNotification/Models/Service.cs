using System;
using System.Collections.Generic;

namespace ServiceNotification.Models
{
    public partial class Service
    {
        public Service()
        {
            Request = new HashSet<Request>();
            ServiceDetail = new HashSet<ServiceDetail>();
        }

        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public bool? ExpirationNotice { get; set; }
        public bool? Enabled { get; set; }

        public virtual ICollection<Request> Request { get; set; }
        public virtual ICollection<ServiceDetail> ServiceDetail { get; set; }
    }
}
