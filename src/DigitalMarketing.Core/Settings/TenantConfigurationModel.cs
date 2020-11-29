using Newtonsoft.Json;
using System.Collections.Generic;

namespace DigitalMarketing.Model.Settings
{
    public class TenantConfigurationModel
    {
        public string Title { get; set; }
        public List<Page> Pages { get; set; }
        public ThirdPartyServices ThirdPartyServices { get; set; }

    }
}