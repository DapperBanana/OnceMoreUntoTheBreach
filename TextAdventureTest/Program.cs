using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace textAdventure2
{
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
            string playerName = GetPlayerName();
            FirstScenario(playerName);

        }

        public static void gameTitle()
        {
            Console.WriteLine("Hey this in the beginning of a text adventure game.");
            Console.WriteLine("Press 'Enter' to begin.");
            Console.ReadLine();
        }

        static string GetPlayerName()
        {
            Console.WriteLine("What is your name, adventurer?");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome, {name}!");
            return name;
        }

        static void FirstScenario(string playerName)
        {
            Console.WriteLine("You awaken in a dark forest.  A path leads north, and a river flows east.");
            Console.WriteLine("Do you go north or east? (north/east)");
            string choice = Console.ReadLine();

            ProcessFirstScenarioChoice(choice);

            Console.ReadLine();

        }

        static void ProcessFirstScenarioChoice(string choice)
        {
            if (choice.ToLower() == "north")
            {
                Console.WriteLine("You travel north. You encounter a goblin!");
            }
            else if (choice.ToLower() == "east")
            {
                Console.WriteLine("You follow the river east. You find a small boat.");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

    }
}
