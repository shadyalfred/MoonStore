namespace MoonStore.Models.Auth;

public enum CustomerStatus
{
}

public class Customer : ApplicationUser
{
    public virtual CustomerStatus Status { get; set; }
    public virtual ShoppingCart ShoppingCart { get; set; }
    public virtual IEnumerable<Order> Orders { get; set; }
}
