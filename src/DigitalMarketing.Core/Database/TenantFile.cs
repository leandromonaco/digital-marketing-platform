using System;
using System.Collections.Generic;

namespace DigitalMarketing.Model.Database
{
    public partial class TenantFile
    {
        public TenantFile()
        {
            TenantConfiguration = new HashSet<TenantConfiguration>();
        }

        public Guid Id { get; set; }
        public string Filename { get; set; }

        public virtual ICollection<TenantConfiguration> TenantConfiguration { get; set; }
    }
}
