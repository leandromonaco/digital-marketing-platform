using System;
using System.Collections.Generic;

namespace DigitalMarketing.Model.Database
{
    public partial class MessageHistory
    {
        public Guid Id { get; set; }
        public Guid TenantId { get; set; }
        public DateTime Date { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Message { get; set; }
        public bool IsDelivered { get; set; }

        public virtual Tenant Tenant { get; set; }
    }
}
