using DigitalMarketing.Model.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DigitalMarketing.Web.Model
{
    /// <summary>
    /// A state container for head tags
    /// https://stackoverflow.com/questions/59197729/dynamic-hosts-cshtml-file-in-blazor-with-c-sharp-code
    /// </summary>
    public class TenantConfigurationSession
    {
        /// <summary>
        /// Page title
        /// </summary>
        public TenantConfigurationModel Settings => _settings;

        public Guid TenantId { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }

        // internal store
        private TenantConfigurationModel _settings;

        /// <summary>
        /// Set the page title
        /// </summary>
        /// <param name="title"></param>
        public void SetSettings(TenantConfigurationModel settings)
        {
            _settings = settings;
            HeadChanged?.Invoke();
        }

        /// <summary>
        /// Event raised when data changes
        /// </summary>
        public event Action HeadChanged;
    }

}
