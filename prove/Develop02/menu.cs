// This defines the class name as menu.
public class Menu
{
    // This is the main introduction that will be sent to the user.
    public string _introduction = "Welcome to Journal Program!";

    // Makes a list of all of the possible options the user can choose.
    public List<string> _userChoices = new List<string>{"Display",
                                                        "Write",
                                                        "Load",
                                                        "Save",
                                                        "Quit"};

    // This creates a variable to hold the user's choice.
    public int _userChoice;

    // The "Introduce" function introduces what the program is.
    public void Introduce()
    {
        Console.WriteLine(_introduction);
    }

    // The "RunSystem" is what controls the main the user interface and loop
    // until the user is done with the program.
    public void RunSystem()
    {

        // Should I declare this as a public variable or just leave it?
        Journal journal= new Journal();

        // this "do" statement will run until the user puts in "5" for quit.
        do
        {

            // Tells the user to choose the possible choices.
            Console.WriteLine("Please select the following choices:");

            // The loop goes through the possible choice, prints the number for
            // each of them with a period and then prints the choice.
            for (int i = 1; i <= _userChoices.Count; i++)
            {
                Console.WriteLine($"{i}. {_userChoices[i - 1]}");
            }

            // Tells the user to put int the choice of 1 through 5, to be more
            // clear.
            Console.Write("Choice (1-5): ");

            // Gets the user's choice and stores it into the public variable
            // "_userChoice".
            _userChoice = int.Parse(Console.ReadLine());

            // This goes through of the possible choices the user chose and 
            // gets the function the user chose.
            if (_userChoice == 1)
            {

                // Gets the Display function of the journal.
                journal.Display();
            }
            else if (_userChoice == 2)
            {

                // Gets the Writing function of the journal.
                journal.Write();
            }
            else if (_userChoice == 3)
            {

                // Gets the Load file function of the journal.
                journal.Load();
            }
            else if (_userChoice == 4)
            {
                // Gets the save file function of the journal.
                journal.Save();
            }
        
        // If the user does not type "5" for quit or types something other than
        // the possible choices, it will just keep rerunning the system.
        } while (_userChoice != 5);
    }

}