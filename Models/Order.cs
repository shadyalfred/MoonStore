using MoonStore.Models.Auth;

namespace MoonStore.Models;

public enum OrderStatus
{
}

public class Order
{
    public int Id { get; set; }
    public virtual Customer Customer { get; set; }
    public virtual OrderStatus Status { get; set; }
    public virtual IEnumerable<OrderDetails> OrderDetails { get; set; }
    public DateTime CreatedAt { get; set; }

    public decimal Total
    {
        get
        {
            return OrderDetails.Sum(od => od.Product.Price * od.Quantity);
        }
    }
}
