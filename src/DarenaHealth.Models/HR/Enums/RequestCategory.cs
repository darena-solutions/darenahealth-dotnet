namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// https://hl7.org/fhir/us/core/STU6.1/ValueSet-us-core-servicerequest-category.html
/// </summary>
public enum RequestCategory
{    
    /// Social Determinants of Health category
    SDOH = 0,

    /// Functional Status category
    FunctionalStatus = 1,

    /// Disability Status category
    DisabilityStatus = 2,

    /// Cognitive Status category
    CognitiveStatus = 3,

    /// Evaluation procedure (386053000)
    EvaluationProcedure = 4,

    /// Social service procedure (410606002)
    SocialServiceProcedure = 5,

    /// Laboratory procedure (108252007)
    LaboratoryProcedure = 6,

    /// Imaging procedure (363679005)
    Imaging = 7,

    /// Counselling procedure (409063005)
    Counselling = 8,

    /// Education procedure (409073007)
    Education = 9,

    /// Surgical procedure (387713003)
    SurgicalProcedure = 10
}
