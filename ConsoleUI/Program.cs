using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
