using CommonLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main()
        {
            var AppManager = Bootstrapper();

            AppManager.StartProgram();
        }

        static ApplicationManager Bootstrapper()
        {
            return new ApplicationManager(
                        new InputManager(),
                        new OutputManager(),
                        new AlphaVantageAPIManager()
                    );
        }
    }
}
