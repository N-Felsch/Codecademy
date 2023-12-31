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
        Console.WriteLine("The door is locked! See if one of your three keys will open it.");
      }

      // Get which key to use with switch
      Console.WriteLine("Enter a number (1-3)");
      string keyChoice = Console.ReadLine().ToUpper();

      switch (keyChoice)
      {
        case "1":
          Console.WriteLine("You choose the first key. Lucky choice! The door opens and NOTHING is there. Strange...\n THE END.");
          break;
        case "2":
          Console.WriteLine("You choose the second key. The door doesn't open.\n THE END.");
          break;
        case "3":
          Console.WriteLine("You choose the third key. The door doesn't open.\n THE END.");
          break;
        default:
          return;
      }

      // User answer riddle
      Console.WriteLine("Type your answer: ");
      string riddleAnswer = Console.ReadLine().ToUpper();

      // User answer equation
      if (riddleAnswer == "NOTHING")
      {
        Console.WriteLine($"The door opens and {riddleAnswer} is there.\n You turn off the light and run back to your room and lock the door.\n THE END.");
      } else {
        Console.WriteLine("You answer incorrectly. The door doesn't open. THE END.");
      }
     

    }
  }
}



