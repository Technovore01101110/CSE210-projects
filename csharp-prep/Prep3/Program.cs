using System;

class Program
{
    static void Main(string[] args)
    {
        string game_play = "yes";
        while (game_play == "yes")
        {
            Random randomgenerator = new Random();
            int magic_number = randomgenerator.Next(1, 100);
            int user_guess;
            do
            {
                Console.Write("What is your guess? ");
                user_guess = int.Parse(Console.ReadLine());

                if (user_guess == magic_number)
                {
                    Console.WriteLine("You guessed it!");
                }
                else if (user_guess <= magic_number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
            } while (user_guess != magic_number);

            Console.WriteLine("Would You like to play again(yes/no)? ");
            game_play = Console.ReadLine();
        }
    }
}