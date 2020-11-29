using System;
using System.Collections.Generic;

namespace DigitalMarketing.Model.Database
{
    public partial class CustomerBak
    {
        public Guid Id { get; set; }
        public Guid TenantId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
