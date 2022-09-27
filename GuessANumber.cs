using System;

namespace GuessTheNumberByToni
{
    internal class GuessANumber
    {
        static void Main(string[] args)
        {
            int max = 101;
            int levels = 1;
        start:
            int tries = 5;
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, max);
            while (true)
            {
                Console.Write($"Guess the number (1-{max}): ");
                string playersinput = Console.ReadLine();
                tries--;
                Console.WriteLine($"{tries} more tries left");
                bool isValid = int.TryParse(playersinput, out int playerNumber);
                if (isValid&&playerNumber<=max&&playerNumber>0)
                {
                    if (playerNumber==computerNumber)
                    {
                        Console.WriteLine("You guessed it!");
                        levels++;
                        max = 201;
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
                if (tries<=0)
                {
                    Console.WriteLine($"You dont get the number for 5 tries");
                    break;
                }
            }
            Console.Write("Do you whant new game: [yes] or [no]");
            string playerRestart = Console.ReadLine();
            if (playerRestart=="Yes"||playerRestart=="yes")
            {
                goto start;
            }

        }
    }
}
