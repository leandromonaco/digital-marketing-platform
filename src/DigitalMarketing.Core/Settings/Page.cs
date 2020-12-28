using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DigitalMarketing.Model.Settings
{
    public class Page
    {
        public string Name { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public List<Section> Sections { get; set; }
    }
}