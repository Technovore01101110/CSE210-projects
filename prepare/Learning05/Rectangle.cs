class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(double lengthP, double widthP, string colorP) : base(colorP)
    {
        _length = lengthP;
        _width = widthP;
    }

    public override double GetArea()
    {
        double area = _length * _width;
        return area;
    }
}