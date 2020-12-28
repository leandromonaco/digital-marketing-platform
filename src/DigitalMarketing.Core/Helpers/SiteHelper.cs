﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalMarketing.Core.Database;
using DigitalMarketing.Model.Extensions;
using DigitalMarketing.Model.Settings;
using Microsoft.Extensions.Caching.Memory;

namespace DigitalMarketing.Model.Helpers
{
    public static class SiteHelper
    {
        private static MemoryCacheOptions options = new MemoryCacheOptions();
        private static MemoryCache _cache = new MemoryCache(options);

        public static string GetLabel(string domain)
        {
            string[] domainSplit = SplitDomain(domain);
            return domainSplit[0].ToString();
        }

        public static bool IsTestUrl(string domain)
        {
            string[] domainSplit = SplitDomain(domain);
            if (domainSplit.Length > 1)
            {
                return true;
            }
            return false;
        }

        private static string[] SplitDomain(string domain)
        {
            domain = domain.Replace("www.", "").Replace(".com", "").Replace(".co.nz", "");
            var domainSplit = domain.Split('.');
            return domainSplit;
        }

        public static async Task<Tenant> IdentifyTenant(string host)
        {
            Tenant tenant;
       
            var cacheId = host;
            var isCached = _cache.TryGetValue(cacheId, out tenant);

            if (!isCached)
            {
                //Get Tenant from Database
                DatabaseRepository databaseRepository = new DatabaseRepository();
                var label = SiteHelper.GetLabel(host);
                tenant = await databaseRepository.GetTenantAsync(label);

                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSize(1)
                                                                     .SetSlidingExpiration(TimeSpan.FromHours(24));

                // Save data in cache.
                _cache.Set(cacheId, tenant, cacheEntryOptions);
            }

            return tenant;
        }
    }
}
