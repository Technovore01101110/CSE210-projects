class EternalGoal : Goal
{
    public EternalGoal(string nameP, string descriptionP, int pointsP) :
    base(nameP, descriptionP, pointsP) { }

    public override void CompleteGoal()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points.");
    }

    public override string ToString()
    {
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
    }
}