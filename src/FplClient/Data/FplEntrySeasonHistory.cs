using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplEntrySeasonHistory
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("season_name")]
        public string SeasonName { get; set; }

        [JsonProperty("total_points")]
        public int TotalPoints { get; set; }

        [JsonProperty("rank")]
        public int? Rank { get; set; }

        [JsonProperty("season")]
        public string Season { get; set; }

        [JsonProperty("player")]
        public int Player { get; set; }
    }
}
