class Swimming : Exercise
{
    private int _laps;
    
    public Swimming(string dateP, int timeP, int lapsP) : base(dateP, timeP)
    {
        _laps = lapsP;
    }

    public override double GetDistance()
    {
        double distance = _laps * 50.0 / 1000.0 * 0.62;
        return distance;
    }

    public override double GetSpeed()
    {
        double speed = GetDistance() / GetTime() * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = GetTime() / GetDistance();
        return pace;
    }
}