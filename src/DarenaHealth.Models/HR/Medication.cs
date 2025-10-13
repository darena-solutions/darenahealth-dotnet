using System;
using System.Collections.Generic;
using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model used to represent a medication resource
/// </summary>
public class Medication : PatientBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Medication"/> class
    /// </summary>
    public Medication()
    {
        MedicationSupplies = new List<MedicationSupply>();
    }

    /// <summary>
    /// Gets the display text of a code value
    /// </summary>
    public string CodeValueDisplay => CodeValue?.DisplayName;

    /// <summary>
    /// Gets the last filled date
    /// </summary>
    public string LastFilledValue => LastFilled?.ToShortDateString();

    /// <summary>
    /// Gets or sets the medication statement event type
    /// </summary>
    public MedicationStatementEventType MedicationStatementEventType { get; set; }

    /// <summary>
    /// Gets or sets the medication's author
    /// </summary>
    public MedicationAuthor Author { get; set; }

    /// <summary>
    /// Gets or sets the reason code value for this medication if the medication's data is absent
    /// </summary>
    public CodeValue DataAbsentReason { get; set; }

    /// <summary>
    /// Gets or sets the list of supplies required for this medication
    /// </summary>
    public List<MedicationSupply> MedicationSupplies { get; set; }

    /// <summary>
    /// Gets or sets the medication quantity/dose
    /// </summary>
    public Quantity Dose { get; set; }

    /// <summary>
    /// Gets or sets the medication's quantity
    /// </summary>
    public Quantity Quantity { get; set; }

    /// <summary>
    /// Gets or sets the medication's days supply
    /// </summary>
    public Quantity DaysSupply { get; set; }

    /// <summary>
    /// Gets or sets the medication's status code
    /// </summary>
    public string StatusCode { get; set; }

    /// <summary>
    /// Gets or sets the medication's Intent
    /// </summary>
    public MedicationRequestIntent Intent { get; set; }

    /// <summary>
    /// Gets or sets the medication's Category
    /// </summary>
    public MedicationRequestCategory Category { get; set; }

    /// <summary>
    /// Gets or sets the medication Requester
    /// </summary>
    public MedicationRequester Requester { get; set; }

    /// <summary>
    /// Gets or sets the date this medication was entered
    /// </summary>
    public DateTime EnteredAt { get; set; }

    /// <summary>
    /// Gets or sets the date this medication was started
    /// </summary>
    public DateTime? StartedAt { get; set; }

    /// <summary>
    /// Gets or sets the date this medication was stopped
    /// </summary>
    public DateTime? StoppedAt { get; set; }

    /// <summary>
    /// Gets or sets the date this medication was last filled
    /// </summary>
    public DateTime? LastFilled { get; set; }

    /// <summary>
    /// Gets or sets the does frequency code value (SNOMEDCT) for this medication
    /// </summary>
    public CodeValue DoseFrequencyCodeValue { get; set; }

    /// <summary>
    /// Gets or sets the Free text dosage instructions e.g. SIG
    /// </summary>
    public string DosageInstructions { get; set; }

    /// <summary>
    /// Gets or sets the dose frequency of medication
    /// </summary>
    public double? DoseFrequency { get; set; }

    /// <summary>
    /// Gets or sets the period of frequency for medication
    /// </summary>
    public double? DosePeriod { get; set; }

    /// <summary>
    /// Gets or sets the dose frequency by unit of time for this medication
    /// </summary>
    public double DoseFrequencyUnitOfTime { get; set; }

    /// <summary>
    /// Gets or sets the dose frequency by unit of measure for time for this medication
    /// </summary>
    public string DoseFrequencyUnitOfMeasure { get; set; }

    /// <summary>
    /// Gets or sets the number of refills
    /// </summary>
    public double Refills { get; set; }

    /// <summary>
    /// Gets or sets the amount of medication to supply per dispense
    /// </summary>
    public Quantity RefillQuantity { get; set; }

    /// <summary>
    /// Gets or sets the reported value
    /// </summary>
    public bool Reported { get; set; }

    /// <summary>
    /// Gets or sets the Medication Dispense Type (Trial fill, partial fill, emergency fill, etc.)
    /// </summary>
    public MedicationDispenseType? DispenseType { get; set; }

    /// <summary>
    /// Gets or sets the Medication order that authorizes the dispense (Reference(US Core MedicationRequest Profile))
    /// </summary>
    public string AuthorizingRequest { get; set; }

    /// <summary>
    /// Gets or sets the Medication reference
    /// </summary>
    public string MedicationReference { get; set; }
}
