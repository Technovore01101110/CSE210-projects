class Cycling : Exercise
{
    private double _speed;
    
    public Cycling(string dateP, int timeP, double speedP) : base(dateP, timeP)
    {
        _speed = speedP;
    }

    public override double GetDistance()
    {
        double distance = _speed / 60 * GetTime();
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }
}