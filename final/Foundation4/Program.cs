using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();

        Exercise running = new Running("12/03/2025", 25, 2);
        exercises.Add(running);

        Exercise cycling = new Cycling("12/05/2025", 15, 19);
        exercises.Add(cycling);

        Exercise swimming = new Swimming("12/08/2025", 12, 14);
        exercises.Add(swimming);
        Console.WriteLine(swimming.GetDistance());

        foreach (Exercise exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}