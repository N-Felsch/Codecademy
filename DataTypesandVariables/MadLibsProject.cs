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

      string story = $"This morning {name} woke up feeling {adjOne}. 'It is going to be a {adjTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {nounOne}, which made all the {fruit} very {adjThree}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);

    }
  }
}
