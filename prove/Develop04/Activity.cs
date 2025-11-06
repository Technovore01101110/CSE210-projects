class Activity
{
    private int _duration;
    private string _title;
    private string _description;

    public Activity(string titleP, string descriptionP)
    {
        _title = titleP;
        _description = descriptionP;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void RunPrologue()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_title} Activity\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like your session: ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get Ready...");
        Timer.PauseWithAnimation();
    }

    public void RunEnd()
    {
        Console.WriteLine("\nWell done!!");
        Timer.PauseWithAnimation();
        
        Console.WriteLine($"You have completed another {_duration} seconds of {_title} Activity.");
        Timer.PauseWithAnimation();
    }
    
}