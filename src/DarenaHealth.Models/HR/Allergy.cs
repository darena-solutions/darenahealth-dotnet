using System.Collections.Generic;
using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model used to represent an allergy resource
/// </summary>
public class Allergy : PatientBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Allergy"/> class
    /// </summary>
    public Allergy()
    {
        Identifiers = new List<Identifier>();
    }

    /// <summary>
    /// Gets or sets the time range this allergy is/was active
    /// </summary>
    public TimeRange TimeRange { get; set; }

    /// <summary>
    /// Gets or sets the id of the patient this allergy belongs to
    /// </summary>
    public string PatientId { get; set; }
        
    /// <summary>
    /// Gets or sets the clinical status of the allergy: active | inactive | resolved
    /// </summary>
    public AllergyClinicalStatus ClinicalStatus { get; set; }
        
    /// <summary>
    /// Gets or sets the verification status of the allergy: unconfirmed | confirmed | refuted | error
    /// </summary>
    public AllergyVerificationStatus VerificationStatus { get; set; }
        
    /// <summary>
    /// Gets or sets the coded value for the allergy reaction
    /// </summary>
    public List<CodeValue> Reactions { get; set; }
}