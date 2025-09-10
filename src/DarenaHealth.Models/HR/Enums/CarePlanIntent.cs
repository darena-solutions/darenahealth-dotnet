namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Based on: https://hl7.org/fhir/R4/valueset-care-plan-intent.html
/// </summary>
public enum CarePlanIntent
{
    /// <summary>
    /// The request is a suggestion made by someone/something that does not have an intention to ensure it occurs and without providing an authorization to act.
    /// </summary>
    Proposal = 0,

    /// <summary>
    /// The request represents an intention to ensure something occurs without providing an authorization for others to act.
    /// </summary>
    Plan = 1,

    /// <summary>
    /// The request represents a request/demand and authorization for action by a Practitioner.
    /// </summary>
    Order = 2,

    /// <summary>
    /// The request represents a component or option for a RequestGroup that establishes timing, conditionality and/or other constraints among a set of requests. Refer to [[[RequestGroup]]] for additional information on how this status is used.
    /// </summary>
    Option = 3
}
