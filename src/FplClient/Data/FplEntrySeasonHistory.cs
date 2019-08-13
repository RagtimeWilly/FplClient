using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplEntrySeasonHistory
    {
        [JsonProperty("season_name")]
        public string SeasonName { get; set; }

        [JsonProperty("total_points")]
        public int TotalPoints { get; set; }

        [JsonProperty("rank")]
        public int? Rank { get; set; }
    }
}
