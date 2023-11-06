using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Defining password parameters
            int minLength = 5;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!@#$%^&*()_+={}[]|\":>?<`~";

            // Getting user input for password
            Console.WriteLine("Enter a new password please.");
            string userPass = Console.ReadLine();

            // Password score-r
            int score = 0;

            // Equation for scoring
            if (userPass.Length >= minLength) 
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

            if (Tools.Contains(userPass, specialChars))
            {
                score++;
            }

            // Switch for telling user how they did
            switch (score)
            {
                case 4:
                case 5:
                    Console.WriteLine("Extremely Strong.");
                    break;
                case 3:
                    Console.WriteLine("Strong.");
                    break;
                case 2:
                    Console.WriteLine("Medium.");
                    break;
                case 1:
                    Console.WriteLine("Weak.");
                    break;
                default:
                    Console.WriteLine("The password doesn't meet any standards.");
                    break;
            }


            // Debug
            Console.WriteLine(score);

            // TEST PROGRAM, HAS BREAKS!!!!!



        }
    }
}