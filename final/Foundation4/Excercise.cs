abstract class Exercise
{
    private DateOnly _date;
    private int _time;

    public Exercise(string dateP, int timeP)
    {
        _date = DateOnly.Parse(dateP);
        _time = timeP;
    }

    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {this.GetType()} ({_time} min): Distance {Math.Round(GetDistance(), 1)} miles, Speed: {Math.Round(GetSpeed(), 2)} mph, Pace: {Math.Round(GetPace(), 2)} min per mile";
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public int GetTime()
    {
        return _time;
    }
}