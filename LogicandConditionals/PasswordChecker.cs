using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Defining password parameters
      int minLength = 0;
      string uppercase = userpass;
      string lowercase;
      string digits;
      string specialChars;

      // Getting user input for password
      Console.WriteLine("Enter a new password please.");
      string userPass = Console.ReadLine();

      // Password score-r
      int score = 0;

      // Equation for scoring
      if (userPass >= minLength) 
      {
        score++;
      }

      if (Tools.Contains(userPass, uppercase))
      {
        score++;
      }

      if (Tools.Contains(userPass, lowercase))
      {
        score++;
      }

      if (Tools.Contains(userPass, digits))
      {
        score++;
      }

      if (Tools.Contains(userPass, specialsChars))
      {
        score++;
      }

      // Debug
      Console.WriteLine(score);



    }
  }
}
