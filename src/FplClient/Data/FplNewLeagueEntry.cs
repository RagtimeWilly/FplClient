using System;
using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplNewLeagueEntry
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("entry_name")]
        public string EntryName { get; set; }

        [JsonProperty("player_first_name")]
        public string PlayerFirstName { get; set; }

        [JsonProperty("player_last_name")]
        public string PlayerLastName { get; set; }

        [JsonProperty("joined_time")]
        public DateTime JoinedAt { get; set; }

        [JsonProperty("entry")]
        public int Entry { get; set; }

        [JsonProperty("league")]
        public int League { get; set; }
    }
}
