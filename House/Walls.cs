using System;

namespace House
{
    internal class Walls : IPart
    {
        public static int CountWalls { get; set; } = 0;

        public Walls()
        {
            CountWalls++;
        }

        public void Info()
        {
            Console.WriteLine(typeof(Walls));
        }
    }
}
