public class Product
{
    private string name;
    private int productId;
    private decimal price;
    private int quantity;

    // Constructor
    public Product(string name, int productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Getter and setter for Name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Getter and setter for ProductId
    public int ProductId
    {
        get { return productId; }
        set { productId = value; }
    }

    // Getter and setter for Price
    public decimal Price
    {
        get { return price; }
        set { price = value; }
    }

    // Getter and setter for Quantity
    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    // Calculate the total cost of the product (price * quantity)
    public decimal CalculateProductCost()
    {
        return price * quantity;
    }
}
