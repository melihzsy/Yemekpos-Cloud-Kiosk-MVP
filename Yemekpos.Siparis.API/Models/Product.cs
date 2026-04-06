namespace Yemekpos.Siparis.API.Models;

public sealed class Product
{
    public Guid Id { get; init; } = Guid.NewGuid();

    public required string Name { get; init; }

    public decimal Price { get; init; }

    public required ProductCategory Category { get; init; }
}

public enum ProductCategory
{
    Hamburger = 1,
    Beverage = 2,
    Side = 3,
    Dessert = 4,
    Other = 99
}
