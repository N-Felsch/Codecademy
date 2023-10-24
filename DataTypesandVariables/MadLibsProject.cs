using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is a mad lib program. It takes information from the user and creates a funny random story based on the information given.

      Author: Nicholas F
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Hello! We are about to begin our Mad Lib program, please enjoy this fun experience, if you so desire.");


      // Give the Mad Lib a title:
      string title = "The Ocean that Could";
      Console.WriteLine(title);

      // Define user input and variables:
      Console.WriteLine("Enter a name: ");
      string name = Console.ReadLine();

      // Asking questions to fill Mad Lib
      Console.WriteLine("Enter an adjective please: ");

      // Helping those who don't know what an
      // adjective is, giving a description.
      Console.WriteLine("\n(An adjective is a word that describes a noun, like a color (‘blue’), or feeling (‘silly’), texture  (‘soft’).)\n");
      // Back to the program

      string adjOne = Console.ReadLine();
      Console.WriteLine("Enter another adjective please: ");
      string adjTwo = Console.ReadLine();
      Console.WriteLine("Last adjective (I promise) please: ");
      string adjThree = Console.ReadLine();

      Console.WriteLine("Please enter a verb: ");
      
      // Helping those who do not know what a verb is
      Console.WriteLine("\n(A verb is a word that represents an action, like ‘sit’, ‘eat’, ‘sleep’)\n");
      // Back to the program
      string verb = Console.ReadLine();
      
      Console.WriteLine("Please enter a noun: ");

      // Helping those who do not know what a noun is
      Console.WriteLine("\n(A noun is a person (‘girl’), place (‘cabin’), or thing (‘toaster’).\n");
      // Back to the program

      string nounOne = Console.ReadLine();
      Console.WriteLine("Please enter a second noun: ");
      string nounTwo = Console.ReadLine();
      
      // Random questions
      Console.WriteLine("Please enter an animal: ");
      string animal = Console.ReadLine();
      Console.WriteLine("Please enter a food: ");
      string food = Console.ReadLine();
      Console.WriteLine("Please enter a fruit: ");
      string fruit = Console.ReadLine();
      Console.WriteLine("Please enter a superhero: ");
      string superhero = Console.ReadLine();
      Console.WriteLine("Please enter a country: ");
      string country = Console.ReadLine();
      Console.WriteLine("Please enter a dessert: ");
      string dessert = Console.ReadLine();
      Console.WriteLine("Please enter a year: ");
      string year = Console.ReadLine();

      // The template for the story:

      string story = "This morning _ woke up feeling _. 'It is going to be a _ day!' Outside, a bunch of _s were protesting to keep _ in stores. They began to _ to the rhythm of the _, which made all the _s very _. Concerned, _ texted _, who flew _ to _ and dropped _ in a puddle of frozen _. _ woke up in the year _, in a world where _s ruled the world.";


      // Print the story:

    }
  }
}
