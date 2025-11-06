using System.Runtime.InteropServices;

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string> 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _reflectQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base(
        "Reflection",
@"This activity will help you reflect on times in your life when you have shown
strength and resilience. This will help you recognize the power you have and 
how you can use it in other aspects of your life."
        ) { }
    
    public void RunReflectionActivity()
    {
        Console.WriteLine("\nConsider the following prompt:");

        Random random = new Random();

        int iRandomPrompt = random.Next(0, _prompts.Count - 1);
        Console.WriteLine($"\n --- {_prompts[iRandomPrompt]} ---\n");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in:  ");

        for (int countdown = 5; countdown > 0; countdown--)
        {
            Console.Write($"\b{countdown}");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\b ");

        Timer.Set(GetDuration());
        
        while (!Timer.IsExpired()) {
            int iRandomQuestion = random.Next(0, _reflectQuestions.Count - 1);
            Console.Write($"> {_reflectQuestions[iRandomQuestion]}  ");

            Timer.PauseWithAnimation(rounds: 6);
        }
    }
}