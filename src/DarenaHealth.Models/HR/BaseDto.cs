namespace DarenaHealth.Models.HR;

/// <summary>
/// The base class that all DTO models must inherit
/// </summary>
public class BaseDto
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseDto"/> class
    /// </summary>
    protected BaseDto()
    {
    }

    /// <summary>
    /// Gets or sets the id of the resource
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the id of the Mips report this resource belongs to
    /// </summary>
    public string MipsReportId { get; set; }
}