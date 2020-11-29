using System;
using System.Collections.Generic;

namespace DigitalMarketing.Model.Database
{
    public partial class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid TenantId { get; set; }

        public virtual Tenant Tenant { get; set; }
    }
}
