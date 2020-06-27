using CommonLibrary.Objects;

namespace CommonLibrary
{
    public interface IAlphaVantageAPIManager
    {
        AlphaRequest BuildApiRequest(string stockSymbol);
        GlobalQuote ExecuteApiRequest(AlphaRequest alphaRequest);
    }
}