using System;
using System.Collections.Generic;

namespace DigitalMarketing.Model.Database
{
    public partial class Customer
    {
        public Customer()
        {
            Touchpoint = new HashSet<Touchpoint>();
        }

        public Guid Id { get; set; }
        public Guid TenantId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<Touchpoint> Touchpoint { get; set; }
    }
}
