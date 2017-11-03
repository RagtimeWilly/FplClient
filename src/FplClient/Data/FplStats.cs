using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplStats
    {
        [JsonProperty("headings")]
        public ICollection<FplStatHeading> Headings { get; set; }
    }
}
