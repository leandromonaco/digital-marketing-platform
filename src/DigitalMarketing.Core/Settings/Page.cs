using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DigitalMarketing.Model.Settings
{
    public class Page
    {
        public string Name { get; set; }
        public List<Section> Sections { get; set; }
    }
}