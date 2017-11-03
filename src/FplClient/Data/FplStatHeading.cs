using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplStatHeading
    {
        [JsonProperty("abbr")]
        public object Abbr { get; set; }

        [JsonProperty("category")]
        public object Category { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }
}
