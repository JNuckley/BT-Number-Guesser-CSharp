// See https://aka.ms/new-console-template for more information
using System;

//namespace
namespace NumberGuesser
{
    //main class    class Program
    class Program
    {
        //entry point method for application
        static void Main(string[] args)
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "JN";

            // change text colour
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion,appAuthor);

            // Reset text colour after the above line
            Console.ResetColor();

            // Ask users name
            Console.WriteLine("What is your name?");

            // Get users input
            string input = Console.ReadLine();

            Console.WriteLine("Hello "+input);
            string isContinuingInput = "Y";
            //set correct number
            // int correctNumber = 7;
            while(isContinuingInput == "Y") {
            // create a random object
            Random random = new Random();
            int correctNumber = random.Next(1,10);

            // init guess var. Zero by default
            int guess = 0;
            Console.WriteLine("Guess the number! Please enter your number between 1 and 10");
           
           while(guess != correctNumber) {
               string guessInput = Console.ReadLine();

               //make sure guess is an int
               if(!int.TryParse(guessInput, out guess)) {
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("Please enter a number only. Letters or special characters are not allowed");
                   Console.ResetColor();

                   continue;
               }
               // Cast to int and put in guess var
               guess = Int32.Parse(guessInput);
               // match the guess to the correct number
               if(guess != correctNumber) {
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("Nope, that's not correct. Please try again!");
                   Console.ResetColor();
               } 
           }
            // handle correct answer
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congratulations, You have guessed the correct number!");
            Console.ResetColor();

            // ask if they want to play again
            Console.WriteLine("Would you like to continue playing? Please enter [Y or N]");
            isContinuingInput = Console.ReadLine().ToUpper();
           
           // decide whether to loop back around or exit
            if(isContinuingInput == "Y") {
                continue;
            } else {
                break;
            }
}
        }
    }
}
