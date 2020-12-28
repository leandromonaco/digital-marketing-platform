using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DigitalMarketing.Model.Settings
{
    public class TenantConfigurationModel
    {
        public string Title { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public List<Page> Pages { get; set; }
        public ThirdPartyConfiguration ThirdPartyConfiguration { get; set; }

    }
}