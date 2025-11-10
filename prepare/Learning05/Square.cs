using System.Formats.Asn1;

class Square : Shape
{
    private double _side;

    public Square(double sideP, string colorP) : base(colorP)
    {
        _side = sideP;
    }

    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
}