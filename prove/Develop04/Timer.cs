using System.Runtime.CompilerServices;

class Timer
{
    static int _frameTime = 300;
    private static DateTime _targetTime;
    public static void Set(int number)
    {
        _targetTime = DateTime.Now;
        _targetTime = _targetTime.AddSeconds(number);
    }

    public static bool IsExpired()
    {
        bool expired = DateTime.Now > _targetTime;
        return expired;
    }

    public static void PauseWithAnimation(int rounds = 3)
    {
        for (int i = 1; i <= rounds; i++)
        {
            Console.Write("\b|");
            Thread.Sleep(_frameTime);
            Console.Write("\b/");
            Thread.Sleep(_frameTime);
            Console.Write("\b-");
            Thread.Sleep(_frameTime);
            Console.Write("\b\\");
            Thread.Sleep(_frameTime);
        }
        Console.WriteLine("\b ");
    }
}