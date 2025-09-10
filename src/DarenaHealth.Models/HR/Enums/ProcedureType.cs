namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// The different types of procedures
/// </summary>
public enum ProcedureType
{
    /// <summary>
    /// The procedure is a psychiatry or service procedure
    /// </summary>
    PsychiatryOrService,

    /// <summary>
    /// A counseling type proceudre
    /// </summary>
    Counseling,

    /// <summary>
    /// An education type procedure
    /// </summary>
    Education,

    /// <summary>
    /// A surgical type procedure
    /// </summary>
    Surgical,

    /// <summary>
    /// A diagnostic type procedure
    /// </summary>
    Diagnostic,

    /// <summary>
    /// The procedure is a chiropractic manipulation
    /// </summary>
    ChiropracticManipulation,

    /// <summary>
    /// A documentation type procedure
    /// </summary>
    Documentation,

    /// <summary>
    /// An act type procedure
    /// </summary>
    Act,

    /// <summary>
    /// The procedure is unspecified
    /// </summary>
    Unspecified,

    /// <summary>
    /// A procedure that required a device to be applied
    /// </summary>
    DeviceApplied
}