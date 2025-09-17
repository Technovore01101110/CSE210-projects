using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade Percentage? ");
        int percentage = int.Parse(Console.ReadLine());
        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        Console.WriteLine("");
        Console.WriteLine($"Grade: {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry, You didn't pass the course this time. Keep Trying!");
        }
        
    }
}