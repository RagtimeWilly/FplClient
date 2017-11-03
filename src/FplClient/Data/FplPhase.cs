using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplPhase
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start_event")]
        public long StartEvent { get; set; }

        [JsonProperty("stop_event")]
        public long StopEvent { get; set; }
    }
}
