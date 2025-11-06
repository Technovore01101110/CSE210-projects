class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        };
    private int _entriesCount;

    public ListingActivity() : base(
        "Listing",
@"This activity will help you reflect on the good things in your life
by having you list as many things as you can in a certain area."
        ) { }

    public void RunListingActivity()
    {
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        
        Random random = new Random();
        string prompt = _prompts[random.Next(0, _prompts.Count)];
        Console.WriteLine($" --- {prompt} ---");

        Console.Write("You may begin in:  ");

        for (int countdown = 5; countdown >= 1; countdown--)
        {
            Console.Write($"\b{countdown}");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\b \n");

        Timer.Set(GetDuration());

        while (!Timer.IsExpired())
        {
            Console.Write("> ");
            Console.ReadLine();

            _entriesCount += 1;
        }
        
        Console.WriteLine($"You listed {_entriesCount} items!");
    } 
   
}