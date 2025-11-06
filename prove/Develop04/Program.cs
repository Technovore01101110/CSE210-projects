using System;
using System.Net.Quic;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breath = new BreathingActivity();
        ReflectionActivity reflection = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();

        int choice;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflecting Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                breath.RunPrologue();
                breath.RunBreathingActivity();
                breath.RunEnd();
            }
            else if (choice == 2)
            {
                reflection.RunPrologue();
                reflection.RunReflectionActivity();
                reflection.RunEnd();
            }
            else if (choice == 3)
            {
                listing.RunPrologue();
                listing.RunListingActivity();
                listing.RunEnd();
            }
            
        } while (choice != 4);
    }
}