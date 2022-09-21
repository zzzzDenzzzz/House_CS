using System;

namespace House
{
    internal class Window : IPart
    {
        public static int CountWindow { get; set; } = 0;

        public Window()
        {
            CountWindow++;
        }

        public void Info()
        {
            Console.WriteLine(typeof(Window));
        }
    }
}
