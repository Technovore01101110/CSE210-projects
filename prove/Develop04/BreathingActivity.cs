using System.Threading.Tasks.Dataflow;

class BreathingActivity : Activity{
    private List<string> _breathAnimation = new List<string>{
        "------------",
        "#-----------",
        "##----------",
        "###---------",
        "####--------",
        "#####-------",
        "######------",
        "#######-----",
        "########----",
        "#########---",
        "##########--",
        "###########-",
        "############"
    };

    public BreathingActivity() : base(
        "Breathing",
@"This activity will help you relax by walking your through breathing in and
out slowly. Clear your mind and focus on your breathing."
    ) { }
       
    public void RunBreathingActivity()
    {
        
        Timer.Set(GetDuration());
        while (!Timer.IsExpired())
        {

            Console.WriteLine("\nBreath in...");

            double frameSpeed = 4.0 / _breathAnimation.Count * 1000;

            foreach (string frame in _breathAnimation)
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(frame);

                Thread.Sleep((int)Math.Round(frameSpeed));
            }

            Console.SetCursorPosition(0, Console.CursorTop - 2);

            Console.WriteLine("\nBreath out...");

            frameSpeed = 6.0 / _breathAnimation.Count * 1000;

            foreach (string frame in _breathAnimation.AsEnumerable().Reverse())
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(frame);

                Thread.Sleep((int)Math.Round(frameSpeed));
            }

            if (!Timer.IsExpired())
            {
                Console.SetCursorPosition(0, Console.CursorTop - 2);
            }
        }
        
        Console.WriteLine();
    }
}