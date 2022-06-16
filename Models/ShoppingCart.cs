using MoonStore.Models.Auth;

namespace MoonStore.Models;

public class ShoppingCart
{
    public int Id { get; set; }
    public string CustomerId { get; set; }
    public virtual Customer Customer { get; set; }
    public virtual IEnumerable<Product> Products { get; set; }
}
