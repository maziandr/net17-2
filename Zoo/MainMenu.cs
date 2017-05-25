using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class MainMenu
    {
        private static MainMenu instance;

            private MainMenu()
            { }

            public static MainMenu getInstance()
            {
                if (instance == null)
                instance = new MainMenu();
                return instance;
            }

            public bool Processed(AnimalListInZoo animals)
            {

                Console.WriteLine("\n" + "\n" + "### commands: (kindOfAnimal must be Lion, Tiger, Elephant, Bear, Wolf or Fox)  ###");
                Console.WriteLine("add <nickName> <kindOfAnimal>");
                Console.WriteLine("feed <nickName>");
                Console.WriteLine("cure <nickName>");
                Console.WriteLine("erase <nickName>");
                Console.WriteLine("starve <nickName>");
                Console.WriteLine("destroy");
                Console.WriteLine("exit"); 
                Console.Write("\n" + "Enter need command: ");
 
                string strIn = Console.ReadLine();
                string[] command = strIn.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                if(command.Length > 0 )
                {
                    switch (command[0].ToLower())
                    {
                        case "add":
                            if (command.Length > 2 && animals.AddRecord(command[1], command[2]))
                            {
                                return true;
                            }
                            break;
                        case "feed":
                            if (command.Length > 1 && animals.FeedAnimal(command[1]))
                            {
                                return true;
                            }
                            break;
                        case "cure":
                            if (command.Length > 1 && animals.CureAnimal(command[1]))
                            {
                                return true;
                            }
                            break;
                        case "erase":
                            if (command.Length > 1 && animals.EraseAnimalIfDead(command[1]))
                            {
                                return true;
                            }
                            break;
                        case "starve":
                            if (command.Length > 1 && animals.StarveAnimal(command[1]))
                            {
                                return true;
                            }
                            break;
                        case "destroy":
                            Console.WriteLine("End of zoo...!!!");
                            animals.DestroyZooRandom();
                            return false;
                        case "exit":
                            Console.WriteLine("End of changing zoo...");
                            return false;
                        default:
                            Console.WriteLine("Unrecognized command");
                            return true;
                    }                    
                }
                return true;
            }
    }
}

