using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter you name: ");
        string name = Console.ReadLine();
        
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int PromptUserBirthYear()
    {
        Console.Write("Please enter the year you were born: ");
        int year = int.Parse(Console.ReadLine());

        return year;
    }
    static int SquareNumber(int number)
    {
        int squareNumber = number * number;

        return squareNumber;
    }
    static void DisplayResult(string name, int squareNumber, int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int turningAge = currentYear - birthYear;
        Console.WriteLine($"{name}, the square of your number is {squareNumber}");
        Console.WriteLine($"{name}, you will turn {turningAge} this year.");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int birthYear = PromptUserBirthYear();
        int squareNumber = SquareNumber(favoriteNumber);
        DisplayResult(name, squareNumber, birthYear);
    }
}