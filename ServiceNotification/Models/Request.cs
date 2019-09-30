using System;
using System.Collections.Generic;

namespace ServiceNotification.Models
{
    public partial class Request
    {
        public int RequestId { get; set; }
        public int ServiceId { get; set; }
        public string ServiceUser { get; set; }
        public string ServiceUserEmail { get; set; }
        public string RequestContent { get; set; }
        public bool? ExpirationNotice { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public string RequestUser { get; set; }
        public DateTime? RequestDate { get; set; }
        public string ProcessUser { get; set; }
        public DateTime? ProcessDate { get; set; }
        public int? Status { get; set; }

        public virtual Service Service { get; set; }
    }
}
