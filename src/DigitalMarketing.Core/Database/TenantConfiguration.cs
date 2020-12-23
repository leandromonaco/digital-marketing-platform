using System;
using System.Collections.Generic;

namespace DigitalMarketing.Core.Database
{
    public partial class TenantConfiguration
    {
        public Guid TenantId { get; set; }
        public Guid FileId { get; set; }
        public string Content { get; set; }
        public DateTime LastModified { get; set; }

        public virtual ConfigurationFile File { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
