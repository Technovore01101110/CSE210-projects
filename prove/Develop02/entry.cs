
// This defines the class as Entry class.
public class Entry
{

    // This creates the variables for an entry.
    public DateTime _entryDateTime;
    public string _entryGivenPrompt;
    public string _entryText;


    // This Displays the entry's information in a neat format.
    public void Display()
    {
        Console.WriteLine($"Date: {_entryDateTime} - Prompt: " +
                          $"{_entryGivenPrompt}");
        Console.WriteLine(_entryText);

    }
}