namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Coverage subscriber relationship
/// https://hl7.org/fhir/R4/valueset-subscriber-relationship.html
/// </summary>
public enum CoverageRelationship
{
    /// <summary>
    /// The Beneficiary is a child of the Subscriber
    /// </summary>
    Child = 0,

    /// <summary>
    /// The Beneficiary is a parent of the Subscriber
    /// </summary>
    Parent = 1,

    /// <summary>
    /// The Beneficiary is a spouse or equivalent of the Subscriber
    /// </summary>
    Spouse = 2,

    /// <summary>
    /// The Beneficiary is a common law spouse or equivalent of the Subscriber
    /// </summary>
    Common = 3,

    /// <summary>
    /// The Beneficiary has some other relationship the Subscriber
    /// </summary>
    Other = 4,

    /// <summary>
    /// The Beneficiary is the Subscriber
    /// </summary>
    Self = 5,

    /// <summary>
    /// The Beneficiary is covered under insurance of the subscriber due to an injury.
    /// </summary>
    Injured = 6
}
