using Newtonsoft.Json;
using System.Collections.Generic;

namespace DigitalMarketing.Model.Settings
{
    public class Section
    {
        [JsonProperty(Required = Required.Default)]
        public string Type { get; set; }
        [JsonProperty(Required = Required.Default)]
        public string Title { get; set; }
        [JsonProperty(Required = Required.Default)]
        public string SubTitle { get; set; }
        [JsonProperty(Required = Required.Default)]
        public string Paragraph { get; set; }
        [JsonProperty(Required = Required.Default)]
        public string BackgroundImage { get; set; }
        [JsonProperty(Required = Required.Default)]
        public string BackgroundVideo { get; set; }
        [JsonProperty(Required = Required.Default)]
        public string ButtonText { get; set; }
        [JsonProperty(Required = Required.Default)]
        public string DownloadFile { get; set; }
        [JsonProperty(Required = Required.Default)]
        public string Date { get; set; }
        [JsonProperty(Required = Required.Default)]
        public List<string> Images { get; set; }
    }
}