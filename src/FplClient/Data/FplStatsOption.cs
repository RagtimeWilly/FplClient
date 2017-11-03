using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplStatsOption
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
