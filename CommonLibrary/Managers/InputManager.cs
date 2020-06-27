using System;

namespace CommonLibrary
{
    public class InputManager : IInputManager
    {
        public string RecordStockSymbol()
        {
            return Console.ReadLine();
        }
    }
}
