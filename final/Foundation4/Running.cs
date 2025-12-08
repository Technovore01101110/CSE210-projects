class Running : Exercise
{
    private double _distance;
    
    public Running(string dateP, int timeP, double distanceP) : base(dateP, timeP)
    {
        _distance = distanceP;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = _distance / GetTime() * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = GetTime() / _distance;
        return pace;
    }
}