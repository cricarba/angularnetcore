using System;
using Newtonsoft.Json;

namespace Dale.Domain
{
    public class Product
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }


        [JsonConverter(typeof(StringToIntJsonConverter))]
        [JsonProperty("cost")]
        public int Cost { get; set; }
    }
}
