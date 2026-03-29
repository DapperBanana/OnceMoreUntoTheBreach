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
            first(playerName);

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


        public static void first(string playerName)
        {
            Console.WriteLine("You awaken in a dark forest.");
            Console.WriteLine("To the north, you see a faint light.");
            Console.WriteLine("To the east, you hear the sound of running water.");
            Console.WriteLine("Which way do you go? (north/east)");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "north")
            {
                Console.WriteLine("You head towards the light...");
            }
            else if (choice.ToLower() == "east")
            {
                Console.WriteLine("You follow the sound of water...");
            }
            else
            {
                Console.WriteLine("Invalid choice. You remain in the forest.");
            }
        }
    }
}