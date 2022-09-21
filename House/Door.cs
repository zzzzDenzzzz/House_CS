using System;

namespace House
{
    internal class Door : IPart
    {
        public void Info()
        {
            Console.WriteLine(typeof(Door));
        }
    }
}
