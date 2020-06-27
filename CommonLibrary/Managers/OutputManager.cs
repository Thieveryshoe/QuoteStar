using System;
using CommonLibrary.Objects;

namespace CommonLibrary
{
    public class OutputManager
    {
        public void RequestStockSymbol()
        {
            Console.WriteLine("Please enter the stock symbol that you would like to retrieve:");
        }

        public void PrintQuoteInfo(GlobalQuote globalQuote)
        {
            Console.WriteLine($"Symbol: {globalQuote.Symbol}");
            Console.WriteLine($"Current Price: {globalQuote.CurrentPrice}");
            Console.WriteLine($"Previous Close: {globalQuote.PreviousClose}");
        }
    }
}
