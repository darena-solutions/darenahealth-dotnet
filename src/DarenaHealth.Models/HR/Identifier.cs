namespace DarenaHealth.Models.HR;

/// <summary>
/// The model that represents the identifier of an element
/// </summary>
public class Identifier
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Identifier"/> class
    /// </summary>
    /// <param name="id">The id of the identifier</param>
    /// <param name="extension">An extension for the identifier for another system</param>
    /// <param name="displayName">Optionally provide a display name for the identifier</param>
    public Identifier(string id, string extension, string displayName = null)
    {
        Id = id;
        Extension = extension;
        DisplayName = displayName;
    }

    /// <summary>
    /// Gets or sets the id of the identifier
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the extension of the identifier for another system
    /// </summary>
    public string Extension { get; set; }

    /// <summary>
    /// Gets or sets the display name for identifier
    /// </summary>
    public string DisplayName { get; set; }
}