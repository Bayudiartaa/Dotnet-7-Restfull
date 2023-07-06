namespace WebApi.Models.Product;

using System.ComponentModel.DataAnnotations;

public class CreateRequest
{
    [Required]
    public string? Name { get; set; }

    [Required]
    public int? Price { get; set; }

    [Required]
    public int? Quantity { get; set; }

    [Required]
    public string? Description { get; set; }

}