namespace GuitarsShop.Api.Domain.Entities;

public class Category
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;

    public List<Product> Products { get; set; } = new();
}