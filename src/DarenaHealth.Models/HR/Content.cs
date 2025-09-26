using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// Represents Document Content
/// </summary>
public class Content
{
    /// <summary>
    /// Uri where the data can be found
    /// </summary>
    public string AttachmentUrl { get; set; }

    /// <summary>
    /// Data inline, base64ed
    /// </summary>
    public string Base64Content { get; set; }

    /// <summary>
    /// (USCDI) Mime type of the content, with charset etc.
    /// </summary>
    public string ContentType { get; set; }

    /// <summary>
    /// Get's or sets the document format
    /// </summary>
    public DocumentFormat? DocumentFormat { get; set; }
}
