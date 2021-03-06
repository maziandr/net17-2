﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var Animals = new AnimalListInZoo();
            var menu = MainMenu.getInstance();

            Animals.AddRecord("King", Kind.Lion);
            Animals.AddRecord("Alice", Kind.Fox);
            // Animals.AddRecord("BEER", Kind.Bear);

            while (menu.Processed(Animals))
            {
                Animals.OutputFullList();
            }

            Console.ReadKey();
        }
    }
}
