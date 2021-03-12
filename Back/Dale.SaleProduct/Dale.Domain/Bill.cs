using System;
using Newtonsoft.Json;

namespace Dale.Domain
{
    public class Bill
    {
        [JsonConverter(typeof(StringToIntJsonConverter))]
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonConverter(typeof(StringToIntJsonConverter))]
        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonConverter(typeof(StringToIntJsonConverter))]
        [JsonProperty("client")]
        public int Client { get; set; }

        [JsonConverter(typeof(StringToIntJsonConverter))]
        [JsonProperty("totalAmmount")]
        public int TotalAmmount { get; set; }
    }
}
