using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplBasicEntry
    {
        [JsonProperty("entry")]
        public FplEntry Entry { get; set; }

        [JsonProperty("leagues")]
        public FplEntryLeagues Leagues { get; set; }
    }
}
