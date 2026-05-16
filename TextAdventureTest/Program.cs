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
            ThirdScenario(playerName);
            FourthScenario(playerName);

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

        static void FirstScenario(string playerName)
        {
            Console.WriteLine($"\n{playerName}, you find yourself at a crossroads.");
            Console.WriteLine("A dark forest lies to the north, a shimmering lake to the east, and a field of wheat to the west.");
            Console.WriteLine("Which way do you go? (north/east/west/south)");

            string choice = Console.ReadLine().ToLower();

            if (choice == North)
            {
                Console.WriteLine("You enter the dark forest. The trees loom tall and menacing.");
                Console.WriteLine("A goblin jumps out from behind a tree!\n");
                GoblinEncounter(playerName);

            }
            else if (choice == East)
            {
                Console.WriteLine("You approach the shimmering lake. The water looks inviting.");
                Console.WriteLine("Do you want to take a swim? (yes/no)");
                string swimChoice = Console.ReadLine().ToLower();

                if (swimChoice == Yes)
                {
                    Console.WriteLine("You dive into the lake and feel refreshed. You find a hidden treasure chest!");
                    Console.WriteLine("Congratulations, you found treasure!");
                }
                else if (swimChoice == No)
                {
                    Console.WriteLine("You decide not to swim and continue on your journey.");
                }
                else
                {
                    Console.WriteLine("Invalid choice. You hesitate and decide to move on.");
                }
            }
            else if (choice == West)
            {
                Console.WriteLine("You enter a field of wheat. The wind whispers through the stalks.");
                Console.WriteLine("You see a scarecrow in the distance. As you approach, it starts to move!\n");
                ScarecrowEncounter(playerName);

            }
            else if (choice == South)
            {
                Console.WriteLine("You head south and find a path leading back to town. It seems safe.");
                Console.WriteLine("You arrive at the town safely.");
            }
            else
            {
                Console.WriteLine("Invalid direction. You wander aimlessly.");
            }
        }

        static void SecondScenario(string playerName)
        {
            Console.WriteLine($"\n{playerName}, you come across a rickety bridge over a deep ravine.");
            Console.WriteLine("Do you dare to cross, or find another way? (cross/another)");

            string choice = Console.ReadLine().ToLower();

            if (choice == "cross")
            {
                Console.WriteLine("You carefully cross the bridge. Halfway across, a plank breaks!");
                Console.WriteLine("You manage to grab onto the side and pull yourself to safety.");
                Console.WriteLine("You made it across, but it was a close call!");
            }
            else if (choice == "another")
            {
                Console.WriteLine("You decide to find another way around. After hours of searching, you find a safer path.");
                Console.WriteLine("You lose valuable time, but you avoid the dangerous bridge.");
            }
            else
            {
                Console.WriteLine("Invalid choice. You stand there, indecisive.");
            }
        }

        static void ThirdScenario(string playerName)
        {
            Console.WriteLine($"\n{playerName}, you enter a mysterious cave.");
            Console.WriteLine("The air is cold and damp. You hear strange noises echoing within.");
            Console.WriteLine("Do you proceed deeper, or turn back? (deeper/back)");

            string choice = Console.ReadLine().ToLower();

            if (choice == "deeper")
            {
                Console.WriteLine("You venture deeper into the cave. The darkness surrounds you.");
                Console.WriteLine("Suddenly, you stumble upon a hidden chamber!");
                Console.WriteLine("Inside, you find an ancient artifact. Congratulations!");
            }
            else if (choice == "back")
            {
                Console.WriteLine("You decide to turn back. The cave feels too dangerous.");
                Console.WriteLine("You leave the cave and continue your journey elsewhere.");
            }
            else
            {
                Console.WriteLine("Invalid choice. You hesitate, unsure of what to do.");
            }
        }

        static void FourthScenario(string playerName)
        {
            Console.WriteLine($"\n{playerName}, you are walking and see a hooded figure in the distance. As you approach closer, the figure vanishes.");
            Console.WriteLine("You notice a small object where the figure once stood.");
            Console.WriteLine("Do you pick it up, or ignore it? (pickup/ignore)");

            string choice = Console.ReadLine().ToLower();

            if (choice == "pickup")
            {
                Console.WriteLine("You pick up the object. It is a small, ornate key.");
                Console.WriteLine("Perhaps it unlocks something important...");
            }
            else if (choice == "ignore")
            {
                Console.WriteLine("You decide to ignore the object and continue on your path.");
                Console.WriteLine("You wonder what it could have been, but you move on.");
            }
            else
            {
                Console.WriteLine("Invalid choice. You hesitate and the moment passes.");
            }
        }

        static void GoblinEncounter(string playerName)
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

        static void ScarecrowEncounter(string playerName)
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