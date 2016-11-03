using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplFixtureStatValue
    {
        [JsonProperty("element")]
        public int Element { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
