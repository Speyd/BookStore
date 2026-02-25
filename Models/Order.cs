namespace WebApplication1.Models;

public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public decimal TotalEth { get; set; }
    public string TxHash { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
