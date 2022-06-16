namespace MoonStore.Models;

public class OrderDetails
{
    public int Id { get; set; }
    public virtual Order Order { get; set; }
    public virtual Product Product { get; set; }
    public int Quantity { get; set; }
}
