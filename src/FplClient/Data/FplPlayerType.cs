using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplPlayerType
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("plural_name")]
        public string PluralName { get; set; }

        [JsonProperty("plural_name_short")]
        public string PluralNameShort { get; set; }

        [JsonProperty("singular_name")]
        public string SingularName { get; set; }

        [JsonProperty("singular_name_short")]
        public string SingularNameShort { get; set; }
    }
}
