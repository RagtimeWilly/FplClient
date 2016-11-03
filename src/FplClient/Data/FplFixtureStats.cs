using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplFixtureStats
    {
        [JsonProperty("goals_scored")]
        public FplFixtureStat GoalsScored { get; set; }

        [JsonProperty("assists")]
        public FplFixtureStat Assists { get; set; }

        [JsonProperty("own_goals")]
        public FplFixtureStat OwnGoals { get; set; }

        [JsonProperty("penalties_saved")]
        public FplFixtureStat PenaltiesSaved { get; set; }

        [JsonProperty("penalties_missed")]
        public FplFixtureStat PenaltiesMissed { get; set; }

        [JsonProperty("yellow_cards")]
        public FplFixtureStat YellowCards { get; set; }

        [JsonProperty("red_cards")]
        public FplFixtureStat RedCards { get; set; }

        [JsonProperty("saves")]
        public FplFixtureStat Saves { get; set; }

        [JsonProperty("bonus")]
        public FplFixtureStat Bonus { get; set; }

        [JsonProperty("bps")]
        public FplFixtureStat Bps { get; set; }
    }
}
