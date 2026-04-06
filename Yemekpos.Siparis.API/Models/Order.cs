namespace Yemekpos.Siparis.API.Models;

public sealed class Order
{
    public Guid Id { get; init; } = Guid.NewGuid();

    public DateTimeOffset OrderDate { get; init; } = DateTimeOffset.UtcNow;

    public required string KioskId { get; init; }

    public List<OrderItem> Items { get; init; } = [];

    public decimal TotalPrice => Items.Sum(item => item.TotalPrice);
}

public sealed class OrderItem
{
    public required Guid ProductId { get; init; }

    public required string ProductName { get; init; }

    public int Quantity { get; init; } = 1;

    public decimal UnitPrice { get; init; }

    public decimal TotalPrice => UnitPrice * Quantity;
}
