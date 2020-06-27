using Newtonsoft.Json;

namespace CommonLibrary.Objects
{
    class AlphaVantageDTO
    {
        [JsonProperty("Global Quote")]
        public GlobalQuote globalQuote { get; set; }
    }
}
