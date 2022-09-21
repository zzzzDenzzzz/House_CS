using System;

namespace House
{
    internal class TeamLeader : IWorker
    {
        public void Info()
        {
            Console.WriteLine(typeof(TeamLeader));
        }

        public void InfoHouse(House house)
        {
            house.ShowHouse();
        }
    }
}
