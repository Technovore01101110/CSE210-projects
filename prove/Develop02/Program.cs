using System;

class Program
{
    static void Main(string[] args)
    {
        // This creates a new menu type variable, starts introducing the
        // program, and runs the main menu system.
        Menu menu = new Menu();
        menu.Introduce();
        menu.RunSystem();
    }
}