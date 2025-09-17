using System;

class Program
{
    static void Main(string[] args)
    {
        //Asking for First Name and recieving it.
        Console.Write("What is your first name? ");
        String FirstName = Console.ReadLine();
        //Asking for Last Name and recieving it.
        Console.Write("What is your last name? ");
        String LastName = Console.ReadLine();

        //To add a line space.
        Console.WriteLine("");

        //Displays Name in James Bond Style.
        Console.WriteLine($"Your name is {LastName}, {FirstName} {LastName}.");


    }
}