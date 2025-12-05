using System;

class Program
{
    static void Main(string[] args)
    {
        const string orderBorder = "#############################################";
        List<Order> orders = new List<Order>();

        Order steveOrder = new Order("Steve Hanks", "333 Spangled Drive", "Rexburg", "Idaho", "United States");
        steveOrder.AddProduct("Infinity Cube", 1, 5.99, 4);
        orders.Add(steveOrder);
        
        Order bobbyOrder = new Order("Bobby Robert", "241 North Road", "Lehi", "Utah", "United States");
        bobbyOrder.AddProduct("Nintendo Switch", 231, 299.99, 1);
        bobbyOrder.AddProduct("Nintendo Switch Controllers", 240, 30.99, 5);
        bobbyOrder.AddProduct("Super Smash Brothers SD - Nintendo Switch", 250, 35.99, 1);
        orders.Add(bobbyOrder);

        Order songOrder = new Order("Song Jinwu", "Shinjuku-dori Avenue", "Tokyo", "Tokyo Metropolis", "Japan");
        songOrder.AddProduct("Healing Potion", 101, 12.50, 3);
        songOrder.AddProduct("Mana Crystal", 202, 45.00, 5);
        songOrder.AddProduct("Shadow Dagger", 303, 120.75, 1);
        songOrder.AddProduct("Hunter's Cloak", 404, 89.99, 2);
        songOrder.AddProduct("Dungeon Map Scroll", 505, 15.25, 4);
        orders.Add(songOrder);

        foreach(Order order in orders)
        { 
            Console.WriteLine(orderBorder);
            Console.WriteLine($"Total Cost: {order.GetTotalCost()}");
            Console.WriteLine("\nSHIPPING LABEL:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("\nPACKING LABEL:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(orderBorder);
        }
    }
}