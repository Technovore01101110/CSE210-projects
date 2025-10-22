using System;
// Author: Nathan Sharp
// Name: Scripture memorizer
// Time: 3+ hours
// Comments: I hope you enjoy what I created because I went all out.
// Exceeding Requirements: I added the option of either a user's custom
//                         scripture or a random one from a csv file.


class Program
{
    static void Main(string[] args)
    {
        Scripture scripture;

        // This cleans the screen.
        Console.Clear();
        Console.Write("Would you like to use your own scripture(y/n): ");
        string custom_scripture = Console.ReadLine();

        if (custom_scripture == "n")
        {
            // This initializes the scripture class with it grabbing a random scripture.
            scripture = new Scripture();
        }
        else
        {
            // The program gets verse information from user.
            Console.Write("Name of book: ");
            string book = Console.ReadLine();
            Console.Write("Chapter: ");
            string chapter = Console.ReadLine();
            Console.Write("Verse Numbers(2 or 1-2): ");
            string verseNumber = Console.ReadLine();
            Console.Write("Verse: ");
            string verse = Console.ReadLine();

            // Then, it puts the user information into the scripture class.
            scripture = new Scripture(book, chapter, verseNumber, verse);
        }

        // Initializes the loop for the memorization.
        bool run = true;
        while (run)
        {
            // This displays the scripture reference and the scripture.
            scripture.Display();

            // This sees if the user wants to quit.
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string isQuit = Console.ReadLine();

            // If the user quits or there is no more words left, it will 
            // change.
            // run to false, ending the program.
            if (isQuit != "quit" && scripture.AnyWordsLeft())
            {
                // This hides a random amount of words.
                scripture.HideRandomWords();
            }
            else
            {
                // This will end the loop.
                run = false;
            }
        }


    }
}