namespace WebApplication2.DTOs;
public class ConfirmOrderDto
{
    public int UserId { get; set; }
    public List<CartItemDto> CartItems { get; set; }
    public string TxHash { get; set; }
}