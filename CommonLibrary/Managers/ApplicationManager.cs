using System;
using CommonLibrary.Objects;

namespace CommonLibrary
{
    public class ApplicationManager : IApplicationManager
    {
        private IInputManager _inputManager;
        private IOutputManager _outputManager;
        private IAlphaVantageAPIManager _apiManager;

        public string StockSymbol { get; set; }
        public AlphaRequest Request { get; set; }
        public GlobalQuote GlobalQuote { get; set; }

        public ApplicationManager(IInputManager inputManager, IOutputManager outputManager, IAlphaVantageAPIManager apiManager)
        {
            _inputManager = inputManager;
            _outputManager = outputManager;
            _apiManager = apiManager;
        }

        public void StartProgram()
        {
            _outputManager.RequestStockSymbol();
            StockSymbol = _inputManager.RecordStockSymbol();
            // check for valid stock symbol from DB
            Request = _apiManager.BuildApiRequest(StockSymbol);
            GlobalQuote = _apiManager.ExecuteApiRequest(Request);
            // record globalQuote results in DB
            _outputManager.PrintQuoteInfo(GlobalQuote);
            //Console.ReadKey();
        }
    }
}
