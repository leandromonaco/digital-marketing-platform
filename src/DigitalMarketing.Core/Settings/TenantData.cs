using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DigitalMarketing.Model.Settings
{
    public class TenantData
    {
        public TenantWebsite Website { get; set; }
        public TenantWorkflows Workflows { get; set; }
        public TenantServices Services { get; set; }

    }
}