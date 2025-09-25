namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Current status of the document. https://hl7.org/fhir/R4/valueset-document-reference-status.html
/// </summary>
public enum DocumentStatus
{
    /// <summary>
    /// This is the current reference for this document.
    /// </summary>
    Current = 0,

    /// <summary>
    /// This reference has been superseded by another reference
    /// </summary>
    Superseded = 1,

    /// <summary>
    /// This reference was created in error.
    /// </summary>
    EnteredInError = 2
}
