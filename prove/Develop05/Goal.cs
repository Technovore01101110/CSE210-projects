class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _done;

    private DateTime _completeDate;

    public Goal(string nameP, string descriptionP, int pointsP, bool doneP = false)
    {
        _name = nameP;
        _description = descriptionP;
        _points = pointsP;
        _done = doneP;
    }

    public Goal(string nameP, string descriptionP, int pointsP, DateTime dateP, bool doneP = false)
    {
        _name = nameP;
        _description = descriptionP;
        _points = pointsP;
        _done = doneP;
        _completeDate = dateP;
    }

    public virtual void Display()
    {
        if (_done)
        {
            Console.WriteLine($"[x] {_name} ({_description})");
            DisplayDate();
        }
        else
        {
            Console.WriteLine($"[ ] {_name} ({_description})");
        }
    }

    public virtual void CompleteGoal()
    {
        SetDone();
        _completeDate = DateTime.Now;
        Console.WriteLine($"Congratulations! You have earned {_points} points.");
    }

    public virtual int GetPoints()
    {
        return _points;
    }

    public bool IsDone()
    {
        return _done;
    }

    public void SetDone()
    {
        _done = true;
    }

    public void SetCompleteDate()
    {
        _completeDate = DateTime.Now;
    }

    public void DisplayDate()
    {
        Console.WriteLine($"\tCompleted: {_completeDate}");
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetName()
    {
        return _name;
    }

    public DateTime GetCompleteDate()
    {
        return _completeDate;
    }

    public override string ToString()
    {
        if (IsDone())
        {
            return $"SimpleGoal|{_name}|{_description}|{_points}|{_done}|{GetCompleteDate()}";
        }
        else
        {
            return $"SimpleGoal|{_name}|{_description}|{_points}|{_done}";
        }
    }
}