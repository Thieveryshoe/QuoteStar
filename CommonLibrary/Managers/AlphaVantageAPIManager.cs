using System;
using System.IO;
using System.Net;
using CommonLibrary.Objects;
using Newtonsoft.Json;

namespace CommonLibrary
{
    public class AlphaVantageAPIManager : IAlphaVantageAPIManager
    {
        public AlphaRequest BuildApiRequest(string stockSymbol)
        {
            return new AlphaRequest
            {
                Function = "GLOBAL_QUOTE",
                ApiKey = "05A2F27KQQ1KG28R",
                Symbol = stockSymbol
            };
        }

        public GlobalQuote ExecuteApiRequest(AlphaRequest alphaRequest)
        {
            String baseEndpoint = "https://www.alphavantage.co/query?function={0}&symbol={1}&apikey={2}";
            String alphaEndPoint = String.Format(baseEndpoint, alphaRequest.Function, alphaRequest.Symbol, alphaRequest.ApiKey);

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(alphaEndPoint);

            HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream); //TODO: add null check here

            string json = readStream.ReadToEnd();
            // Releases the resources of the response.
            response.Close();
            // Releases the resources of the Stream.
            readStream.Close();
            AlphaVantageDTO dto = JsonConvert.DeserializeObject<AlphaVantageDTO>(json);
            return dto.globalQuote;
        }
    }
}
