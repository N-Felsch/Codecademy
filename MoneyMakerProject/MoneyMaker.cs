using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");

      // Ask user for amount to convert
      Console.WriteLine("Please enter a value you'd like to convert to coins:");
      string userInput = Console.ReadLine();
      
      // Convert to double
      double userInputConv = Convert.ToDouble(userInput);

      // Repeat users input
      Console.WriteLine($"{userInput} cents is equal to . . .");

      // Setting variables to use for our equations
      int goldCoin = 10;
      int silverCoin = 5;
      
      // Equations
      double goldCoins = Math.Floor(userInputConv / goldCoin);
      double goldCoinsRemain = (userInputConv % goldCoin);
      double silverCoins = Math.Floor(goldCoinsRemain / 5);
      double silverCoinsRemain = (silverCoins % silverCoin);


      // Debug
      Console.WriteLine(silverCoinsRemain);
      
    }
  }
}
