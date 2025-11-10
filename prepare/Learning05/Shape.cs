abstract class Shape
{
    private string _color;

    public Shape(string colorP)
    {
        _color = colorP;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string colorP)
    {
        _color = colorP;
    }

    public abstract double GetArea();
}