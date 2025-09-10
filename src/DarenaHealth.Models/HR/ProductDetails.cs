namespace DarenaHealth.Models.HR;

/// <summary>
/// Model that contains the details of a product
/// </summary>
public class ProductDetails
{
    /// <summary>
    /// Gets or sets the id of product
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the unencoded name for the product
    /// </summary>
    public string UnencodedName { get; set; }

    /// <summary>
    /// Gets or sets the lot number
    /// </summary>
    public string LotNumber { get; set; }

    /// <summary>
    /// Gets or sets the code product value
    /// </summary>
    public CodeValue Product { get; set; }

    /// <summary>
    /// Gets or sets the manufacturer of product
    /// </summary>
    public string Manufacturer { get; set; }
}