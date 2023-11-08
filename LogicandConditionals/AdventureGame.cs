using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");

            // Starting the story
            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");

            // Instructing how to play
            Console.WriteLine("Type \"YES\" or \"NO\":");
            string noiseChoice = Console.ReadLine().ToUpper();

            // Decision tree
            if (noiseChoice == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room!");
                Console.WriteLine("THE END.");
            } else if (noiseChoice == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
            }

            // Instruction
            Console.WriteLine("Type OPEN or KNOCK: ");
            string doorChoice = Console.ReadLine().ToUpper();
      
            // Decision Tree
            if (doorChoice == "KNOCK")
            {
                Console.WriteLine("A voive behind the door speaks. It says, \"Answer this riddle: \"");
                Console.WriteLine("\"Poor people have it. Rich people need it. If you eat it your die. What is it\"");
            } else if (doorChoice == "OPEN") {
        
            }
      




     
        }
    }
}