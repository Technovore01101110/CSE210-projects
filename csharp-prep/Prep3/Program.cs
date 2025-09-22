using System;

class Program
{
    static void Main(string[] args)
    {
        string gamePlay = "yes";
        
        while (gamePlay == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int userGuess;
            do
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                }
                else if (userGuess <= magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
            } while (userGuess != magicNumber);

            Console.WriteLine("Would You like to play again(yes/no)? ");
            gamePlay = Console.ReadLine();
        }
    }
}