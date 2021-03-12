using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Dale.Domain
{
    public class Client
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonConverter(typeof(StringToIntJsonConverter))]
        [JsonProperty("identificationDocument")]
        public int IdentificationDocument { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("numberPhone")]
        public string NumberPhone { get; set; }
    }
}
