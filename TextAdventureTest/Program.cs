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
            SecondScenario(playerName);

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

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Please enter a valid name:");
                name = Console.ReadLine();
            }

            return name;
        }

        public static void FirstScenario(string playerName)
        {
            Console.WriteLine("You are standing in a dark forest, " + playerName + ".");
            Console.WriteLine("You see a path to the north and a path to the east.");
            Console.WriteLine("Which path do you choose? (north/east)");

            string choice = Console.ReadLine();

            if (choice.ToLower() == "north")
            {
                NorthScenario(playerName);
            }
            else if (choice.ToLower() == "east")
            {
                EastScenario();
            }
            else
            {
                Console.WriteLine("Invalid choice. You stumble around aimlessly.");
            }
        }

        public static void SecondScenario(string playerName)
        {
            Console.WriteLine("You find yourself at a crossroads, " + playerName + ".");
            Console.WriteLine("To the west, you see a shimmering lake. To the south, a towering mountain.");
            Console.WriteLine("Which way do you go? (west/south)");

            string choice = Console.ReadLine();

            if (choice.ToLower() == "west")
            {
                Console.WriteLine("You approach the lake and see a beautiful mermaid.");
            }
            else if (choice.ToLower() == "south")
            {
                Console.WriteLine("You begin to climb the mountain. It's a long and arduous journey.");
            }
            else
            {
                Console.WriteLine("Invalid choice. You wander around in confusion.");
            }
        }

        static void NorthScenario(string playerName)
        {
            Console.WriteLine("You travel north and encounter a friendly goblin.");
            Console.WriteLine("The goblin offers you a magic sword.");
            Console.WriteLine("Do you accept the sword? (yes/no)");

            string swordChoice = Console.ReadLine();

            if (swordChoice.ToLower() == "yes")
            {
                Console.WriteLine("You accept the sword and feel a surge of power!");
            }
            else
            {
                Console.WriteLine("You decline the sword. The goblin seems disappointed.");
            }
        }

        static void EastScenario()
        {
            Console.WriteLine("You travel east and fall into a pit!");
            Console.WriteLine("It's dark and damp. You can't see a way out.");
        }


    }
}