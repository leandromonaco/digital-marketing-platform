using DigitalMarketing.Core.Database;
using DigitalMarketing.Model.Helpers;
using DigitalMarketing.Model.Settings;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

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
                parsedConfig = JsonSerializer.Deserialize<TenantConfigurationModel>(json);
            }
            else
            {
                parsedConfig = JsonSerializer.Deserialize<TenantConfigurationModel>(tenant.TenantConfiguration.Where(tc => tc.File.Filename.Equals("tenant.production.json")).FirstOrDefault().Content);
            }

            using (JsonDocument doc = JsonDocument.Parse(json))
            {
                JsonElement root = doc.RootElement;

                var pages = root.GetProperty("Pages").EnumerateObject();
                parsedConfig.Pages = new List<Page>();
                foreach (var page in pages)
                {
                    var p = new Page { Sections = new List<Section>() };

                    var sections = page.Value.GetProperty("Sections").EnumerateObject();
                    foreach (var section in sections)
                    {
                        var s = JsonSerializer.Deserialize<Section>(section.Value.ToString());
                        p.Sections.Add(s);
                    }
                    parsedConfig.Pages.Add(p);
                }
            }

            return parsedConfig;
        }
    }
}
