namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// The different device types
/// </summary>
public enum DeviceType
{
    /// <summary>
    /// Documents the device and its use, or impacts or alters the treatment, care plan, or encounter
    /// </summary>
    Applied,

    /// <summary>
    /// Documents an order for the device indicated
    /// </summary>
    Order,

    /// <summary>
    ///  Documents a recommendation to use the device
    /// </summary>
    Recommended
}