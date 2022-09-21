using System;

namespace House
{
    internal class Basement : IPart
    {
        public void Info()
        {
            Console.WriteLine(typeof(Basement));
        }
    }
}
