using System;

namespace House
{
    internal class Worker : IWorker
    {
        public void Info()
        {
            Console.WriteLine(typeof(Worker));
        }

        public void AddPart(House house)
        {
            if (house.GetBasement() == null)
            {
                house.AddBasement();
            }
            else if (house.GetWalls() == null)
            {
                for (int i = 0; i < 4; i++)
                {
                    house.AddWalls();
                }
            }
            else if (house.GetDoor() == null)
            {
                house.AddDoor();
            }
            else if (house.GetWindow() == null)
            {
                for (int i = 0; i < 4; i++)
                {
                    house.AddWindow();
                }
            }
            else if (house.GetRoof() == null)
            {
                house.AddRoof();
            }
            else
            {
                Console.WriteLine("House is built!!!");
            }
        }
    }
}
