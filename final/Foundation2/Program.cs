using System;
using System.Collections.Generic;

// Address class
class Address
{
    private string Street { get; set; }
    private string City { get; set; }
    private string State { get; set; }
    private string Country { get; set; }

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public bool IsInUsa()
    {
        return Country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public override string ToString()
    {
        return $"{Street}\n{City}, {State}\n{Country}";
    }
}

// Customer class
class Customer
{
    private string Name { get; set; }
    private Address Address { get; set; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public bool IsInUsa()
    {
        return Address.IsInUsa();
    }

    public override string ToString()
    {
        return $"{Name}\n{Address}";
    }
}

// Product class
class Product
{
    private string Name { get; set; }
    private string ProductId { get; set; }
    private double Price { get; set; }
    private int Quantity { get; set; }

    public Product(string name, string productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public double GetTotalCost()
    {
        return Price * Quantity;
    }

    public override string ToString()
    {
        return $"{Name} (ID: {ProductId})";
    }
}

// Order class
class Order
{
    private Customer Customer { get; set; }
    private List<Product> Products { get; set; }

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (var product in Products)
        {
            total += product.GetTotalCost();
        }
        double shippingCost = Customer.IsInUsa() ? 5 : 35;
        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (var product in Products)
        {
            packingLabel += $"{product}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return Customer.ToString();
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Create address instances
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create customer instances
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create product instances
        Product product1 = new Product("Laptop", "001", 999.99, 1);
        Product product2 = new Product("Mouse", "002", 19.99, 2);
        Product product3 = new Product("Keyboard", "003", 49.99, 1);

        // Create order instances
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        // Add products to orders
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order details
        List<Order> orders = new List<Order> { order1, order2 };
        foreach (var order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("Total Cost:");
            Console.WriteLine($"${order.CalculateTotalCost():0.00}");
            Console.WriteLine(new string('=', 40));
        }
    }
}
