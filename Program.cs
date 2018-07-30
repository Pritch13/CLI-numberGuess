using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            GetAppInfo();

            GreetUser();

            while (true)
            {


                int guess = 0;

                Random random = new Random();

                int correctNumber = random.Next(1, 11);

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string inputName = Console.ReadLine();

                    if (!int.TryParse(inputName, out guess))
                    {

                        PrintColorMessage(ConsoleColor.Red, "That isn't a number, please try again!");

                        continue;

                    }

                    guess = Int32.Parse(inputName);

                    if (guess != correctNumber)
                    {

                        PrintColorMessage(ConsoleColor.Red, "Incorrect, please try again!");
                    }
                }

                PrintColorMessage(ConsoleColor.Green, "Correct!");

                Console.WriteLine("Would you like to play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if(answer =="Y")
                {
                    continue;
                } else if (answer == "N")
                {
                    return;
                }

            }

        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Sam Pritchard";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0} Version: {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");

            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", input);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
