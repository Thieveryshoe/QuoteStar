using CommonLibrary.Objects;
using Moq;
using Xunit;

namespace CommonLibrary.Tests
{
    public class ApplicationManagerTests
    {
        private Mock<IInputManager> _mockInputManger;
        private Mock<IOutputManager> _mockOutputManager;
        private Mock<IAlphaVantageAPIManager> _mockApiManager;
        private ApplicationManager _sut;


        public ApplicationManagerTests()
        {
            _mockInputManger = new Mock<IInputManager>();
            _mockOutputManager = new Mock<IOutputManager>();
            _mockApiManager = new Mock<IAlphaVantageAPIManager>();
            _sut = new ApplicationManager(_mockInputManger.Object, _mockOutputManager.Object, _mockApiManager.Object);
        }

        [Fact]
        public void StartProgram_it_should_call_outputManger_twice()
        {
            _mockInputManger.Setup(x => x.RecordStockSymbol()).Returns("F");
            _mockApiManager.Setup(x => x.BuildApiRequest("F")).Returns(new AlphaRequest());
            _mockApiManager.Setup(x => x.ExecuteApiRequest(It.IsAny<AlphaRequest>())).Returns(new GlobalQuote());

            _sut.StartProgram();

            _mockOutputManager.Verify(x => x.RequestStockSymbol());
            _mockOutputManager.Verify(x => x.PrintQuoteInfo(It.IsAny<GlobalQuote>()));
        }
    }
}
