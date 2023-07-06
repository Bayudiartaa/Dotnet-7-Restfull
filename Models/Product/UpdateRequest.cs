namespace WebApi.Models.Product;

public class UpdateRequest
{
    public string? Name { get; set; }

    public int? Price { get; set; }

    public int? Quantity { get; set; }

    public string? Description { get; set; }

    // helpers

    private string? replaceEmptyWithNull(string? value)
    {
        // replace empty string with null to make field optional
        return string.IsNullOrEmpty(value) ? null : value;
    }
}