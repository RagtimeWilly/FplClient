using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplGameSettings
    {
        [JsonProperty("game")]
        public FplGame Game { get; set; }
    }
}
