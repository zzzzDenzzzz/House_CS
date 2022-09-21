﻿using System;
using System.Collections.Generic;

namespace House
{
    internal class House
    {
        List<IPart> parts;

        public House()
        {
            parts = new List<IPart>();
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
            foreach (var part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}