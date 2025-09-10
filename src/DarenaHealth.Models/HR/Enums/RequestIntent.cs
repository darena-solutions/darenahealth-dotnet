﻿namespace DarenaHealth.Models.HR.Enums;

public enum RequestIntent
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
    /// The request represents a legally binding instruction authored by a Patient or RelatedPerson.
    /// </summary>
    Directive = 2,

    /// <summary>
    /// The request represents a request/demand and authorization for action by a Practitioner.
    /// </summary>
    Order = 3,

    /// <summary>
    /// The request represents an original authorization for action.
    /// </summary>
    OriginalOrder = 4,

    /// <summary>
    /// The request represents an automatically generated supplemental authorization for action based on a parent authorization together with initial results of the action taken against that parent authorization.
    /// </summary>
    ReflexOrder = 5,

    /// <summary>
    /// The request represents the view of an authorization instantiated by a fulfilling system representing the details of the fulfiller's intention to act upon a submitted order.
    /// </summary>
    FillerOrder = 6,

    /// <summary>
    /// An order created in fulfillment of a broader order that represents the authorization for a single activity occurrence. E.g. The administration of a single dose of a drug.
    /// </summary>
    InstanceOrder = 7,

    /// <summary>
    /// The request represents a component or option for a RequestGroup that establishes timing, conditionality and/or other constraints among a set of requests. Refer to RequestGroup for additional information on how this status is used.
    /// </summary>
    Option = 8
}