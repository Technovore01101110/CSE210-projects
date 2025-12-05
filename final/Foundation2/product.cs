class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _amount;

    public Product(string nameP, int idP, double priceP, int amountP)
    {
        _name = nameP;
        _id = idP;
        _price = priceP;
        _amount = amountP;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetId()
    {
        return _id;
    }

    public int GetAmount()
    {
        return _amount;
    }

    public double GetCost()
    {
        double Cost = _price * _amount;
        return Cost;
    }
}