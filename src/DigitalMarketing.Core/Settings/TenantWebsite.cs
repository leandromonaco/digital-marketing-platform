using System.Collections.Generic;

namespace DigitalMarketing.Model.Settings
{
    public class TenantWebsite
    {
        public string Title { get; set; }
        public Channels Channels { get; set; }
        public Colors Colors { get; set; }
        public List<Page> Pages { get; set; }
    }
}