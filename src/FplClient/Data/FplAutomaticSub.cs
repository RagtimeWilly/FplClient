using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplAutomaticSub
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("element_in")]
        public int ElementIn { get; set; }

        [JsonProperty("element_out")]
        public int ElementOut { get; set; }

        [JsonProperty("entry")]
        public int Entry { get; set; }

        [JsonProperty("event")]
        public int Event { get; set; }
    }
}
