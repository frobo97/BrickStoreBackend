namespace BrickStoreBackend.Models;

public class BrickProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public byte[] Image { get; set; }

    public BrickProduct()
    {
    }

    public BrickProduct(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public BrickProduct(string name, string description, double price, byte[] image)
    {
        Name = name;
        Description = description;
        Price = price;
        Image = image;
    }
}