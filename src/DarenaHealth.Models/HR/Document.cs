using System.Collections.Generic;
using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// Information about a document or note
/// </summary>
public class Document : PatientBase
{
    /// <summary>
    /// Document status
    /// </summary>
    public DocumentStatus Status { get; set; }

    /// <summary>
    /// The kind of document referenced
    /// </summary>
    public DocumentType DocumentType { get; set; }

    /// <summary>
    /// (USCDI) Practitioners who authored the document
    /// </summary>
    public List<string> PractitionerAuthors { get; set; }

    /// <summary>
    /// (USCDI) Organizations who authored the document
    /// </summary>
    public List<string> OrganizationAuthors { get; set; }

    /// <summary>
    /// (USCDI) Patients who authored the document
    /// </summary>
    public List<string> PatientAuthors { get; set; }

    /// <summary>
    /// (USCDI) PractitionerRoles who authored the document
    /// </summary>
    public List<string> PractitionerRoleAuthors { get; set; }

    /// <summary>
    /// (USCDI) RelatedPersons who authored the document
    /// </summary>
    public List<string> RelatedPersonAuthors { get; set; }

    /// <summary>
    /// (USCDI) Devices who authored the document
    /// </summary>
    public List<string> DeviceAuthors { get; set; }

    /// <summary>
    /// Document referenced
    /// </summary>
    public List<Content> Contents { get; set; }
}
