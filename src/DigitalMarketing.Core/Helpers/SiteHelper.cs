using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DigitalMarketing.Model.Extensions;
using DigitalMarketing.Model.Settings;
using DigitalMarketing.Web.Model;
using Microsoft.Extensions.Caching.Memory;

namespace DigitalMarketing.Model.Helpers
{
    public static class SiteHelper
    {
        private static MemoryCacheOptions options = new MemoryCacheOptions();
        private static MemoryCache _cache = new MemoryCache(options);

        public static string GetLabel(string domain, out bool isTest)
        {
            domain = domain.Replace("www.", "").Replace(".com", "").Replace(".co.nz", "");
            var domainSplit = domain.Split('.');
            if (domainSplit.Count() > 1)
            {
                isTest = true;
            }
            else
            {
                isTest = false;
            }
            return domainSplit[0].ToString();
        }

        public static async void IdentifyTenant(string host, TenantConfigurationSession SiteState)
        {
            DatabaseRepository databaseRepository = new DatabaseRepository();
            bool isTest;
            var label = SiteHelper.GetLabel(host, out isTest);
            var tenant = await databaseRepository.GetTenantAsync(label);

            TenantConfigurationModel settings = null;
            TenantConfigurationModel cacheEntry = new TenantConfigurationModel();

            var cacheId = isTest ? $"{tenant.Id}-staging" : $"{tenant.Id}-production";

            if (!_cache.TryGetValue(cacheId, out cacheEntry))
            {
                settings = tenant.LoadConfiguration(isTest);
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetSize(1)
                .SetSlidingExpiration(TimeSpan.FromHours(24));

                // Save data in cache.
                _cache.Set(cacheId, settings, cacheEntryOptions);
            }
            else
            {
                settings = cacheEntry;
            }

            SiteState.TenantId = tenant.Id;
            SiteState.Name = tenant.Name;
            SiteState.Label = tenant.Label;

            SiteState.SetSettings(settings);
        }
    }
}
