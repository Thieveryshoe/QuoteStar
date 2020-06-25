using System;
using CommonLibrary.Objects;

namespace CommonLibrary
{
    public class ApplicationManager
    {
        private InputManager _inputManager;
        private OutputManager _outputManager;
        private AlphaVantageAPIManager _apiManager;

        private string stockSymbol { get; set; }
        private AlphaRequest request { get; set; }
        private GlobalQuote globalQuote { get; set; }

        public ApplicationManager(InputManager inputManager, OutputManager outputManager, AlphaVantageAPIManager apiManager)
        {
            _inputManager = inputManager;
            _outputManager = outputManager;
            _apiManager = apiManager;
        }

        public void StartProgram()
        {
            _outputManager.RequestStockSymbol();
            stockSymbol = _inputManager.RecordStockSymbol();
            // check for valid stock symbol from DB
            request = _apiManager.BuildApiRequest(stockSymbol);
            globalQuote = _apiManager.ExecuteApiRequest(request);
            // record globalQuote results in DB
            _outputManager.PrintQuoteInfo(globalQuote);
            Console.ReadKey();
        }
    }
}
