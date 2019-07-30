using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplElementStats
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
