class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetP, string cityP, string stateP, string countryP)
    {
        _street = streetP;
        _city = cityP;
        _state = stateP;
        _country = countryP;
    }

    public bool IsFromUsa()
    {
        return _country == "United States";
    }

    public string GetAddress()
    {
        return $"{_street}\n\t {_city}, {_state}, {_country}";
    }
}