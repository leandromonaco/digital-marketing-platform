using DigitalMarketing.Model.Helpers;
using DigitalMarketing.Model.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DigitalMarketing.Services.CMS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContentController : ControllerBase
    {
        private readonly ILogger<ContentController> _logger;

        public ContentController(ILogger<ContentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<TenantWebsite> GetAsync(string domain)
        {
            var tenant = await SiteHelper.IdentifyTenant(domain);

            TenantData parsedConfig = null;
            string json = null;

            bool isTest = SiteHelper.IsTestUrl(domain);

            if (isTest)
            {
                json = tenant.TenantConfiguration.Where(tc => tc.File.Filename.Equals("tenant.staging.json")).FirstOrDefault().Content;
                parsedConfig = JsonSerializer.Deserialize<TenantData>(json);
            }
            else
            {
                parsedConfig = JsonSerializer.Deserialize<TenantData>(tenant.TenantConfiguration.Where(tc => tc.File.Filename.Equals("tenant.production.json")).FirstOrDefault().Content);
            }

            return parsedConfig.Website;
        }
    }
}
