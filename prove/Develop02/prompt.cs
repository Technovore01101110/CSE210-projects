
// He defines the class as Prompt.
public class Prompt
{

    // This creates the list of prompts available to use.
    public List<string> _entryPrompts = new List<string> {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
        };

    // This returns a random prompt from the prompt list.
    public string getRandomPrompt()
    {
        // This sets up the random class.
        Random random = new Random();

        // With the random class, it will get a random index for a prompt.
        int randomIndex = random.Next(_entryPrompts.Count);

        // With the random index, it will get the prompt.
        string randomPrompt = _entryPrompts[randomIndex];

        // This will then return the prompt.
        return randomPrompt;
    }
}