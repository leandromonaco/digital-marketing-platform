using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DigitalMarketing.Model.Settings
{
    public class Page
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public List<Section> Sections { get; set; }
    }
}