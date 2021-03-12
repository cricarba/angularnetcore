using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Dale.Domain
{
    public class BillDetailDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("billId")]
        public int BillId { get; set; }

        [JsonProperty("productId")]
        public int ProductId { get; set; }
        [JsonProperty("productName")]
        public string ProductName { get; set; }
        [JsonProperty("cost")]
        public int ProductCost { get; set; }

        [JsonProperty("ammount")]
        public int Ammount { get; set; }
    }
}
