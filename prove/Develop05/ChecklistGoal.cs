using System.Data;
using System.Threading.Channels;

class ChecklistGoal : Goal
{
    private int _roundsCompleted;
    private int _totalRounds;

    private int _bonus;

    public ChecklistGoal(string nameP, string descriptionP, int pointsP,
                         int totalRoundsP, int bonusP, int roundsCompletedP = 0,
                         bool done = false) : base(nameP, 
                                                   descriptionP,
                                                   pointsP,
                                                   done)
    {
        _totalRounds = totalRoundsP;
        _roundsCompleted = roundsCompletedP;
        _bonus = bonusP;
    }

    public ChecklistGoal(string nameP, string descriptionP, int pointsP,
                         int totalRoundsP, int bonusP, DateTime dateP, int roundsCompletedP = 0,
                         bool done = false) : base(nameP, 
                                                   descriptionP,
                                                   pointsP,
                                                   dateP,
                                                   done)
    {
        _totalRounds = totalRoundsP;
        _roundsCompleted = roundsCompletedP;
        _bonus = bonusP;
    }

    public override void Display()
    {
        if (IsDone())
        {
            Console.WriteLine($"[x] {GetName()} ({GetDescription()}) -- Currently Completed: {_roundsCompleted}/{_totalRounds}");
            DisplayDate();
        }
        else
        {
            Console.WriteLine($"[ ] {GetName()} ({GetDescription()}) -- Currently Completed: {_roundsCompleted}/{_totalRounds}");
        }
    }

    public override void CompleteGoal()
    {
        _roundsCompleted += 1;

        if (_roundsCompleted == _totalRounds)
        {
            Console.WriteLine($"Congratulations!!! You have earned a total of {GetPoints()} points.");
            SetDone();
            SetCompleteDate();
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points.");
        }

    }

    public override int GetPoints()
    {
        if (_roundsCompleted == _totalRounds)
        {
            return base.GetPoints() + _bonus;
        }
        else
        {
            return base.GetPoints();
        }
    }

    public override string ToString()
    {
        if (IsDone())
        {
            return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_totalRounds}|{_roundsCompleted}|{GetCompleteDate()}";
        }
        else
        {
            return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_totalRounds}|{_roundsCompleted}";
        }
    }
        
}