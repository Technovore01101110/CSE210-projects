
// This declares the name of the class.
public class Journal
{

    // This sets up a list for the entries.
    public List<Entry> _entries = new List<Entry>();

    // This sets up a variable to hold the file name.
    public string _fileName;

    // This function displays all of the journal entries currently loaded.
    public void Display()
    {

        // This foreach loop goes through the entries list and runs the 
        // entry built-in function for each entry.
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    // This gets a random prompt and collects all the info needed for a 
    // new entry.
    public void Write()
    {

        // This sets up the basic entry variable.
        Entry currentEntry = new Entry();

        // This sets up the Prompt generator.
        Prompt prompt = new Prompt();

        // This runs the built-in function of prompt to choose a random prompt, 
        // and puts it in the entry's prompt variable.
        currentEntry._entryGivenPrompt = prompt.getRandomPrompt();

        // This displays the entry's prompt for the user.
        Console.WriteLine(currentEntry._entryGivenPrompt);

        // This creates a nice set up for the user to put in the input, 
        // receives the input, and stores it into the entry's entryText.
        Console.Write("> ");
        currentEntry._entryText = Console.ReadLine();

        // Adds the current date and time to the entry's date time variable.
        currentEntry._entryDateTime = DateTime.Now;

        // This adds the entire entry to the entries list.
        _entries.Add(currentEntry);
    }

    // This load function gets entry data from a file. 
    // Useful for seeing previous journal entries.
    public void Load()
    {

        // This asks the user for the file name and puts it into a variable.
        Console.Write("File Name: ");
        _fileName = Console.ReadLine();

        // This reads the file and puts each line separate into the list.
        string[] lines = System.IO.File.ReadAllLines(_fileName);


        // This sets up the entry system to put the strings back into a entry
        // class and back into the entries list.
        Entry saved_entry = new Entry();

        // This goes through each line of the lines list and adds the 
        // information back into the entries list.
        foreach (string line in lines)
        {

            // The parts list is a list of the different parts of an entry
            // being splitted by a "|".
            string[] parts = line.Split("|");

            // Each part of an entry is added back into the entry's variables.
            saved_entry._entryDateTime = DateTime.Parse(parts[0]);
            saved_entry._entryGivenPrompt = parts[1];
            saved_entry._entryText = parts[2];

            // Then the entry is added back to the list.
            _entries.Add(saved_entry);

            // This repeats until all the lines have been gone through.
        }
    }

    // This save function saves all current entries in the entries list into a 
    // file.
    public void Save()
    {

        // This asks for the file name and puts the input into a variable.
        Console.Write("File Name: ");
        _fileName = Console.ReadLine();

        // This warns of the risk of deleting data on a file already made.
        Console.WriteLine("This will erase all data on the file. If " +
                          "you did not first load the previous journal " +
                          "entries, they will be lost.");

        // Asks if the user wants to continue and stores the answer in a 
        // variable.
        Console.Write("Continue?(y/n): ");
        string userChoice = Console.ReadLine();

        // If the user says to continue, it will write the file.
        // Anything else will classify as no, so it will skip the save stage.
        if (userChoice.ToLower() == "y")

            // This opens the file or creates a new file to edit.
            using (StreamWriter outputFile = new StreamWriter(_fileName))
            {
                
                // It goes through the list of entries and saves the 
                // information.
                foreach (Entry entry in _entries)
                {

                    // It puts the entry's data into a certain format to load
                    // it later.
                    string csv_entry = $"{entry._entryDateTime}|" +
                                       $"{entry._entryGivenPrompt}|" +
                                       $"{entry._entryText}";

                    // This writes the entry on a new line.
                    outputFile.WriteLine(csv_entry);
                }
            }
    }
}