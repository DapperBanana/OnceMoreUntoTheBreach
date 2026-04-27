using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace textAdventure2
{
    class Program
    {
        private const string North = "north";
        private const string East = "east";
        private const string West = "west";
        private const string South = "south";
        private const string Yes = "yes";
        private const string No = "no";

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
            Console.WriteLine("You see a path to the " + North + " and a path to the " + East + ".");
            Console.WriteLine("Which path do you choose? (" + North + "/" + East + ")");

            string choice = Console.ReadLine();

            if (choice.ToLower() == North)
            {
                NorthScenario(playerName);
            }
            else if (choice.ToLower() == East)
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
            Console.WriteLine("To the " + West + ", you see a shimmering lake. To the " + South + ", a towering mountain.");
            Console.WriteLine("Which way do you go? (" + West + "/" + South + ")");

            string choice = Console.ReadLine();

            if (choice.ToLower() == West)
            {
                Console.WriteLine("You approach the lake and see a beautiful mermaid.");
            }
            else if (choice.ToLower() == South)
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
            Console.WriteLine("Do you accept the sword? (" + Yes + "/" + No + ")");

            string swordChoice = Console.ReadLine();

            if (swordChoice.ToLower() == Yes)
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