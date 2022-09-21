using System;

namespace House
{
    internal class Roof : IPart
    {
        public void Info()
        {
            Console.WriteLine(typeof(Roof));
        }
    }
}
