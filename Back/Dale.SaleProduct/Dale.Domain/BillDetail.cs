using Newtonsoft.Json;

namespace Dale.Domain
{
    public class BillDetail
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("billId")]
        public int BillId { get; set; }

        [JsonProperty("productId")]
        public int ProductId { get; set; }

        [JsonProperty("ammount")]
        public int Ammount { get; set; }
    }
}
