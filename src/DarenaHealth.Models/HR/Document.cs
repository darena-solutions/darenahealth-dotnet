using System.Collections.Generic;
using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// Information about a document or note
/// </summary>
public class Document : PatientBase
{
    public Document()
    {
        Authors = new List<AuthorReference>();
        Contents = new List<Content>();
    }

    /// <summary>
    /// Document status
    /// </summary>
    public DocumentStatus Status { get; set; }

    /// <summary>
    /// The kind of document referenced
    /// </summary>
    public DocumentType DocumentType { get; set; }

    /// <summary>
    /// Gets or sets document authors
    /// </summary>
    public List<AuthorReference> Authors { get; set; }

    /// <summary>
    /// Document referenced
    /// </summary>
    public List<Content> Contents { get; set; }

    /// <summary>
    /// Document Author
    /// </summary>
    public class AuthorReference
    {
        /// <summary>
        /// Gets or sets id of author
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets type of author
        /// </summary>
        public AuthorType Type { get; set; }
    }

    /// <summary>
    /// Type of document authors
    /// </summary>
    public enum AuthorType
    {
        /// <summary>
        /// Practitioner
        /// </summary>
        Practitioner,

        /// <summary>
        /// Organization
        /// </summary>
        Organization,

        /// <summary>
        /// Patient
        /// </summary>
        Patient,

        /// <summary>
        /// PractitionerRole
        /// </summary>
        PractitionerRole,

        /// <summary>
        /// RelatedPerson
        /// </summary>
        RelatedPerson,

        /// <summary>
        /// Device
        /// </summary>
        Device,
    }
}
