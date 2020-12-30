using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DigitalMarketing.Model.Settings
{
    public class TenantConfigurationModel
    {
        public string Title { get; set; }
        public Colors Colors { get; set; }
        public List<Page> Pages { get; set; }
        public ThirdPartyConfiguration ThirdPartyConfiguration { get; set; }

    }
}