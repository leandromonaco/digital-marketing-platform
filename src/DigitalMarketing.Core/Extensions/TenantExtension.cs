using DigitalMarketing.Core.Database;
using DigitalMarketing.Model.Helpers;
using DigitalMarketing.Model.Settings;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace DigitalMarketing.Model.Extensions
{
    public static class ConfigurationExtensions
    {
        public static TenantConfigurationModel LoadConfiguration(this Tenant tenant, string host)
        {
            TenantConfigurationModel parsedConfig = null;
            string json = null;

            bool isTest = SiteHelper.IsTestUrl(host);

            if (isTest)
            {
                json = tenant.TenantConfiguration.Where(tc => tc.File.Filename.Equals("tenant.staging.json")).FirstOrDefault().Content;
                parsedConfig = JsonConvert.DeserializeObject<TenantConfigurationModel>(json);
            }
            else
            {
                parsedConfig = JsonConvert.DeserializeObject<TenantConfigurationModel>(tenant.TenantConfiguration.Where(tc => tc.File.Filename.Equals("tenant.production.json")).FirstOrDefault().Content);
            }

            //Retrieve Pages
            parsedConfig.Pages = new List<Page>();
            var jObject = JObject.Parse(json);
            foreach (var page in jObject["Site"]["Pages"])
            {
                var p = new Page();

                p.Sections = page
                            .Children()
                            .Children()
                            .Children()
                            .Select(i => i.ToObject<Section>())
                            .ToList();

                parsedConfig.Pages.Add(p);
            }

            return parsedConfig;
        }
    }
}
