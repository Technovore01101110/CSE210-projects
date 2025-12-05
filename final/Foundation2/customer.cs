class Customer
{
    private string _name;
    private Address _address;

    public Customer(string nameP, string streetP, string cityP, string stateP, string countryP)
    {
        _name = nameP;
        _address = new Address(streetP, cityP, stateP, countryP);
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }

    public bool IsFromUsa()
    {
        return _address.IsFromUsa();
    }
}