using CommonLibrary.Objects;

namespace CommonLibrary
{
    public interface IApplicationManager
    {
        string StockSymbol { get; set; }
        AlphaRequest Request { get; set; }
        GlobalQuote GlobalQuote { get; set; }
        void StartProgram();
    }
}