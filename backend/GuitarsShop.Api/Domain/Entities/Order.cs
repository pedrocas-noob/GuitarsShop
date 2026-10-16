using GuitarsShop.Api.Domain.Enums;
namespace GuitarsShop.Api.Domain.Entities;

public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = null!; 
    public DateTime Data { get; set; } = DateTime.UtcNow;
    public decimal Total { get; set; }
    public enum Status
    {
        Pending,
        Shipped,
        Delivered,
        Cancelled
    }
    
    public OrderStatus Status { get; set; }

    public List<OrderItem> OrderItems { get; set; } = new();
}