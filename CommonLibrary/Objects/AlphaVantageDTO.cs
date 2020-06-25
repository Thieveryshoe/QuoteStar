using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CommonLibrary.Objects
{
    class AlphaVantageDTO
    {
        [JsonProperty("Global Quote")]
        public GlobalQuote globalQuote { get; set; }
    }
}
