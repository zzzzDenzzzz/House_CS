using System;

namespace House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var team = new Team();

            team.AddTeamLeader();
            team.AddWorker(3);
            team.ShowTeam();

            Console.WriteLine();

            var house = new House();

            team.GetWorker().AddPart(house);
            team.GetWorker().AddPart(house);
            team.GetWorker().AddPart(house);
            team.GetWorker().AddPart(house);
            team.GetWorker().AddPart(house);

            team.GetTeamLeader().InfoHouse(house);

            team.GetWorker().AddPart(house);
            team.GetWorker().AddPart(house);

            Console.WriteLine();
        }
    }
}
