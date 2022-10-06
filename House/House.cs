using MyLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace House
{
    internal class House
    {
        List<IPart> parts;

        public House()
        {
            parts = new List<IPart>();
            Loger loger = new Loger(DateTime.Now, TypeMessage.InfoMessage, typeof(House).ToString());
            SoapFormatter soapFormatter = new SoapFormatter();
            using (Stream fStream = File.Create($"House_{Loger.PATH_LOG_FILE}"))
            {
                soapFormatter.Serialize(fStream, loger);
            }
        }

        public void AddBasement()
        {
            parts.Add(new Basement());
        }

        public Basement GetBasement()
        {
            foreach (var item in parts)
            {
                if (item is Basement)
                {
                    return item as Basement;
                }
            }
            return null;
        }

        public void AddWalls()
        {
            parts.Add(new Walls());
        }

        public Walls GetWalls()
        {
            foreach (var item in parts)
            {
                if (item is Walls)
                {
                    return item as Walls;
                }
            }
            return null;
        }

        public void AddDoor()
        {
            parts.Add(new Door());
        }

        public Door GetDoor()
        {
            foreach (var item in parts)
            {
                if (item is Door)
                {
                    return item as Door;
                }
            }
            return null;
        }

        public void AddWindow()
        {
            parts.Add(new Window());
        }

        public Window GetWindow()
        {
            foreach (var item in parts)
            {
                if (item is Window)
                {
                    return item as Window;
                }
            }
            return null;
        }

        public void AddRoof()
        {
            parts.Add(new Roof());
        }

        public Roof GetRoof()
        {
            foreach (var item in parts)
            {
                if (item is Roof)
                {
                    return item as Roof;
                }
            }
            return null;
        }

        public void ShowHouse()
        {
            if (parts.Count == 0)
            {
                Console.WriteLine("Стройка не началась");
            }
            else
            {
                foreach (var part in parts)
                {
                    Console.WriteLine(part);
                }
            }
        }
    }
}
