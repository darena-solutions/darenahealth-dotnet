using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

public class ComponentCodeValue
{
    /// <summary>
    /// Gets or sets the observation component type
    /// </summary>
    public ObservationComponent ComponentType { get; set; }

    /// <summary>
    /// Gets or sets the observation component code
    /// </summary>
    public string ComponentCode { get; set; }

    /// <summary>
    /// Gets or sets the coded value for a missing action or observation
    /// </summary>
    public CodeValue NotDoneReason { get; set; }
}
