using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    // Constructor
    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    // Add a product to the order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Calculate the total cost of the order
    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;

        foreach (Product product in products)
        {
            totalCost += product.CalculateProductCost();
        }

        // Add one-time shipping cost based on the customer's location
        totalCost += customer.IsInUSA() ? 5 : 35;

        return totalCost;
    }

    // Get the packing label for the order
    public string GetPackingLabel()
    {
        string packingLabel = $"Packing Label for Order:\nCustomer: {customer.Name}\n";

        foreach (Product product in products)
        {
            packingLabel += $"Product: {product.Name}, Product ID: {product.ProductId}\n";
        }

        return packingLabel;
    }

    // Get the shipping label for the order
    public string GetShippingLabel()
    {
        string shippingLabel = $"Shipping Label for Order:\nCustomer: {customer.Name}\n";
        shippingLabel += customer.GetFullAddress();

        return shippingLabel;
    }
}
