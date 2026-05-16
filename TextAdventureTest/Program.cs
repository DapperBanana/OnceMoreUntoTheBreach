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
            Scenarios.FirstScenario(playerName);
            Scenarios.SecondScenario(playerName);
            Scenarios.ThirdScenario(playerName);
            Scenarios.FourthScenario(playerName);

        }

        static void gameTitle()
        {
            Console.WriteLine("Welcome to the Text Adventure Game!");
            Console.WriteLine("----------------------------------");
        }

        static string GetPlayerName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty. Please enter your name: ");
                name = Console.ReadLine();
            }
            return name;
        }

        public static void GoblinEncounter(string playerName)
        {
            Console.WriteLine("The goblin snarls and attacks!");
            Console.WriteLine("Do you fight or run? (fight/run)");

            string choice = Console.ReadLine().ToLower();

            if (choice == "fight")
            {
                Console.WriteLine("You bravely fight the goblin!\n");
                Console.WriteLine("You swing your trusty sword and strike the goblin!");
                Console.WriteLine("With a final blow, you defeat the goblin!\n");
                Console.WriteLine("You gain experience and find a small pouch of gold!\n");
            }
            else if (choice == "run")
            {
                Console.WriteLine("You attempt to run away from the goblin!");
                Console.WriteLine("You narrowly escape the goblin's grasp.\n");
                Console.WriteLine("You lose some ground but avoid a direct confrontation.\n");
            }
            else
            {
                Console.WriteLine("Invalid choice. The goblin takes advantage of your hesitation and attacks!");
                Console.WriteLine("You suffer a blow but manage to defend yourself.");
            }
        }

        public static void ScarecrowEncounter(string playerName)
        {
            Console.WriteLine("The scarecrow creaks and begins to swing its arms!");
            Console.WriteLine("Do you approach cautiously or try to sneak around? (approach/sneak)");

            string choice = Console.ReadLine().ToLower();

            if (choice == "approach")
            {
                Console.WriteLine("You approach the scarecrow cautiously!\n");
                Console.WriteLine("As you get closer, you realize it's just an animated construct.");
                Console.WriteLine("You disable it easily and continue through the field.\n");
            }
            else if (choice == "sneak")
            {
                Console.WriteLine("You try to sneak around the scarecrow!");
                Console.WriteLine("The scarecrow's head turns, and it spots you.\n");
                Console.WriteLine("It begins to move towards you, blocking your path.\n");
            }
            else
            {
                Console.WriteLine("Invalid choice. The scarecrow continues to block your path.\n");
            }
        }
    }
}