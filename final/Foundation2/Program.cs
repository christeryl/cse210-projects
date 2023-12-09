using System;

class Program
{
    static void Main()
    {
        // Create an address
        Address customerAddress = new Address("123 Nephi St.", "Rexburg", "ID", "USA");

        // Create a customer
        Customer customer = new Customer("Ben Bennington", customerAddress);

        // Create products
        Product product1 = new Product("Apple", 1, 2.99m, 1);
        Product product2 = new Product("Bannana", 2, 1.99m, 1);

        // Create an order and add products
        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

        // Display packing label, shipping label, and total cost
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():F2}");
    }
}
