namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Coverage Class Type
/// https://hl7.org/fhir/R4/valueset-coverage-class.html
/// </summary>
public enum CoverageClassType
{
    /// <summary>
    /// An employee group
    /// </summary>
    Group = 0,
    
    /// <summary>
    /// A sub-group of an employee group
    /// </summary>
    SubGroup = 1,
    
    /// <summary>
    /// A specific suite of benefits.
    /// </summary>
    Plan = 2,
    
    /// <summary>
    /// A subset of a specific suite of benefits.
    /// </summary>
    SubPlan = 3,
    
    /// <summary>
    /// A class of benefits.
    /// </summary>
    Class = 4,
    
    /// <summary>
    /// A subset of a class of benefits.
    /// </summary>
    SubClass = 5,
    
    /// <summary>
    /// A sequence number associated with a short-term continuance of the coverage.
    /// </summary>
    Sequence = 6,
    
    /// <summary>
    /// Pharmacy benefit manager's Business Identification Number.
    /// </summary>
    RxBin = 7,
    
    /// <summary>
    /// A Pharmacy Benefit Manager specified Processor Control Number.
    /// </summary>
    RxPcn = 8,
    
    /// <summary>
    /// A Pharmacy Benefit Manager specified Member ID.
    /// </summary>
    RxId = 9,
    
    /// <summary>
    /// A Pharmacy Benefit Manager specified Group number.
    /// </summary>
    RxGroup = 10,
}