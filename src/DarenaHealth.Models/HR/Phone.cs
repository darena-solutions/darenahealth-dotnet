using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// Model that represents a phone number
/// </summary>
public class Phone
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Phone"/> class
    /// </summary>
    /// <param name="number">The phone number</param>
    /// <param name="type">The type of phone number. (Default: 'Cell')</param>
    /// <param name="isPrimary">Indicates if the phone number is primary. (Default: 'false')</param>
    public Phone(string number, ContactPointUse type = ContactPointUse.Mobile, bool isPrimary = false)
    {
        IsPrimary = isPrimary;
        Number = number;
        Type = type;
    }

    /// <summary>
    /// Gets or sets a value indicating whether it is a primary phone number
    /// </summary>
    public bool IsPrimary { get; set; }

    /// <summary>
    /// Gets or sets the phone number
    /// </summary>
    public string Number { get; set; }

    /// <summary>
    /// Gets or sets the phone type
    /// </summary>
    public ContactPointUse Type { get; set; }
}