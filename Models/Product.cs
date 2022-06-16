namespace MoonStore.Models;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Stock { get; set; }
    public string Image { get; set; }
    public string Color { get; set; }
    public decimal Price { get; set; }
    public virtual Category Category { get; set; }
    public virtual Brand Brand { get; set; }
}
