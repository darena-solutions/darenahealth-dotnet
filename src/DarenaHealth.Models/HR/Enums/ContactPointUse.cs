namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// ContactPoint Use values
/// https://hl7.org/fhir/R4/valueset-contact-point-use.html
/// </summary>
public enum ContactPointUse
{
    /// <summary>
    /// A communication contact point at a home; attempted contacts for business purposes might intrude privacy and chances are one will contact family or other household members instead of the person one wishes to call. Typically used with urgent cases, or if no other contacts are available.
    /// </summary>
    Home = 0,

    /// <summary>
    /// An office contact point. First choice for business related contacts during business hours.
    /// </summary>
    Work = 1,

    /// <summary>
    /// A temporary contact point. The period can provide more detailed information.
    /// </summary>
    Temp = 2,

    /// <summary>
    /// This contact point is no longer in use (or was never correct, but retained for records).
    /// </summary>
    Old = 3,

    /// <summary>
    /// A telecommunication device that moves and stays with its owner. May have characteristics of all other use codes, suitable for urgent matters, not the first choice for routine business.
    /// </summary>
    Mobile = 4,
}