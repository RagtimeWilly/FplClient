using System;
using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplEventEntryState
    {
        [JsonProperty("event")]
        public int Event { get; set; }

        [JsonProperty("sub_state")]
        public string SubState { get; set; }

        [JsonProperty("event_day")]
        public int? EventDay { get; set; }

        [JsonProperty("deadline_time")]
        public DateTime DeadlineTime { get; set; }

        [JsonProperty("deadline_time_formatted")]
        public string FormattedDeadlineTime { get; set; }
    }
}
