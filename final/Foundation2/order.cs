using System.Globalization;

class Order
{
    const double usaPrice = 5.00;
    const double foreignPrice = 35.00;

    const string _LabelBorder = "-----------------------------------------";
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(string nameP, string streetP, string cityP, string stateP, string countryP)
    {
        _customer = new Customer(nameP, streetP, cityP, stateP, countryP);
    }

    public void AddProduct(string productNameP, int productIdP, double productPriceP, int productAmountP)
    {
        Product product = new Product(productNameP, productIdP, productPriceP, productAmountP);
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalPrice = 0.0;

        foreach (Product product in _products)
        {
            double productPrice = product.GetCost();
            totalPrice += productPrice;
        }

        if (_customer.IsFromUsa())
        {
            totalPrice += usaPrice;
        }
        else
        {
            totalPrice += foreignPrice;
        }

        return totalPrice;
    }

    public string GetShippingLabel()
    {
        string ShippingLabel = @$"{_LabelBorder}
Ship to: {_customer.GetName()}
         {_customer.GetAddress()}
{_LabelBorder}";

        return ShippingLabel;
    }

    public string GetPackingLabel()
    {
        string packingLabel = $"{_LabelBorder}\nProducts:";
        foreach (Product product in _products)
        {
            packingLabel += $"\n -{product.GetName()} (Id: {product.GetId()})";
            packingLabel += $"\n\tAmount: {product.GetAmount()}";
        }

        packingLabel += $"\n{_LabelBorder}";

        return packingLabel;
    }

}