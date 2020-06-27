using System;
using Newtonsoft.Json;

namespace CommonLibrary.Objects
{
    public class GlobalQuote
    {
        [JsonProperty("01. symbol")]
        public string Symbol { get; set; }
        [JsonProperty("02. open")]
        public decimal OpenPrice { get; set; }
        [JsonProperty("03. high")]
        public decimal HighPrice { get; set; }
        [JsonProperty("04. low")]
        public decimal LowPrice { get; set; }
        [JsonProperty("05. price")]
        public decimal CurrentPrice { get; set; }
        [JsonProperty("06. volume")]
        public int Volume { get; set; }
        [JsonProperty("07. latest trading day")]
        public DateTime LatestTradingDay { get; set; }
        [JsonProperty("08. precious close")]
        public decimal PreviousClose { get; set; }
        [JsonProperty("09. change")]
        public decimal Change { get; set; }
        [JsonProperty("10. change percent")]
        public string ChangePercent { get; set; }
    }
}
