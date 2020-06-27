using CommonLibrary.Objects;

namespace CommonLibrary
{
    public interface IOutputManager
    {
        void RequestStockSymbol();
        void PrintQuoteInfo(GlobalQuote globalQuote);
    }
}