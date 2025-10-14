using System.Dynamic;

class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int whole_number)
    {
        _numerator = whole_number;
        _denominator = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public int GetTop()
    {
        return _numerator;
    }

    public void SetTop(int top)
    {
        _numerator = top;
    }

    public int GetBottom()
    {
        return _denominator;
    }

    public void SetBottom(int bottom)
    {
        _denominator = bottom;
    }

    public string GetFractionString()
    {
        string fractionString = _numerator + "/" + _denominator;
        return fractionString;
    }

    public double GetFractionDecimal()
    {
        double fractionDecimal = (double)_numerator / _denominator;

        return fractionDecimal;
    }
}