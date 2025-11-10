using System.Formats.Asn1;

class Circle : Shape
{
    private double _radius;

    public Circle(double radiusP, string colorP) : base(colorP)
    {
        _radius = radiusP;
    }

    public override double GetArea()
    {
        double area = Math.PI * _radius;
        return area;
    }
}