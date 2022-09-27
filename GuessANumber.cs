using System;

namespace GuessTheNumberByToni
{
    internal class GuessANumber
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 101);
            while (true)
            {
                Console.Write("Guess the number (1-100): ");
                string playersinput = Console.ReadLine();
                bool isValid = int.TryParse(playersinput, out int playerNumber);
                if (isValid)
                {
                    if (playerNumber==computerNumber)
                    {
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                    else if (playerNumber>computerNumber)
                    {
                        Console.WriteLine("Too High");
                    }
                    else
                    {
                        Console.WriteLine("Too Low");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }
    }
}
