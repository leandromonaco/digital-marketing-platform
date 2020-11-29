using System;
using System.Collections.Generic;

namespace DigitalMarketing.Model.Database
{
    public partial class TenantConfiguration
    {
        public Guid TenantId { get; set; }
        public Guid FileId { get; set; }
        public string Content { get; set; }

        public virtual ConfigurationFile File { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
