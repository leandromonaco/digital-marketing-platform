using DigitalMarketing.Model.Database;
using DigitalMarketing.Model.Settings;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace DigitalMarketing.Model.Extensions
{
    public static class ConfigurationExtensions
    {
        public static TenantConfigurationModel LoadConfiguration(this Tenant tenant, bool isTest)
        {
            TenantConfigurationModel parsedConfig = null;
            string json = null;

            if (isTest)
            {
                json = tenant.TenantConfiguration.Where(tc => tc.File.Filename.Equals("tenant.staging.json")).FirstOrDefault().Content;
                parsedConfig = JsonConvert.DeserializeObject<TenantConfigurationModel>(json);
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
               
            }
            else
            {
                parsedConfig = JsonConvert.DeserializeObject<TenantConfigurationModel>(tenant.TenantConfiguration.Where(tc => tc.File.Filename.Equals("tenant.production.json")).FirstOrDefault().Content);
            }
            
            return parsedConfig;
        }
    }
}
