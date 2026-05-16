using System;

namespace textAdventure2
{
    public class Scenarios
    {\n        public static void FirstScenario(string playerName)
        {
            Console.WriteLine($"\n{playerName}, you find yourself at a crossroads.");
            Console.WriteLine("A dark forest lies to the north, a shimmering lake to the east, and a field of wheat to the west.");
            Console.WriteLine("Which way do you go? (north/east/west/south)");

            string choice = Console.ReadLine().ToLower();
            string North = "north";
            string East = "east";
            string West = "west";
            string South = "south";
            string Yes = "yes";
            string No = "no";

            if (choice == North)
            {
                Console.WriteLine("You enter the dark forest. The trees loom tall and menacing.");
                Console.WriteLine("A goblin jumps out from behind a tree!\n");
                Program.GoblinEncounter(playerName);

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
                Program.ScarecrowEncounter(playerName);

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

        public static void SecondScenario(string playerName)
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

        public static void ThirdScenario(string playerName)
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

        public static void FourthScenario(string playerName)
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
    }
}