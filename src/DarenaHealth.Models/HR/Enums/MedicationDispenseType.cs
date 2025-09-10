namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// MedicationDispense / PharmacySupplyType
/// https://terminology.hl7.org/5.0.0/ValueSet-v3-ActPharmacySupplyType.html
/// </summary>
public enum MedicationDispenseType
{
    /// <summary>
    /// A fill providing sufficient supply for one day
    /// </summary>
    DailyFill = 0,

    /// <summary>
    /// A supply action where there is no 'valid' order for the supplied medication. E.g. Emergency vacation supply, weekend supply (when prescriber is unavailable to provide a renewal prescription)
    /// </summary>
    EmergencySupply = 1,

    /// <summary>
    /// An emergency supply where the expectation is that a formal order authorizing the supply will be provided at a later date.
    /// </summary>
    ScriptOwing = 2,

    /// <summary>
    /// The initial fill against an order. (This includes initial fills against refill orders.)
    /// </summary>
    FirstFill = 3,

    /// <summary>
    /// A billing arrangement where a Provider charges a separate fee for each intervention/procedure/event or product.
    /// </summary>
    FeeForService = 4,

    /// <summary>
    /// A first fill where the quantity supplied is less than one full repetition of the ordered amount, and also where the strength supplied is less than the ordered strength.
    /// </summary>
    FirstFillPartFillPartial = 5,

    /// <summary>
    /// A first fill where the quantity supplied is equal to one full repetition of the ordered amount, and also where the strength supplied is less than the ordered strength.
    /// </summary>
    FirstFillCompletePartial = 6,

    /// <summary>
    /// A fill where a small portion is provided to allow for determination of the therapy effectiveness and patient tolerance, and also where the strength supplied is less than the ordered strength.
    /// </summary>
    TrialFillPartial = 7,

    /// <summary>
    /// A first fill where the quantity supplied is equal to one full repetition of the ordered amount.
    /// </summary>
    FirstFillComplete = 8,

    /// <summary>
    /// A first fill where the quantity supplied is less than one full repetition of the ordered amount.
    /// </summary>
    FirstFillPartFill = 9,

    /// <summary>
    /// A first fill where the strength supplied is less than the ordered strength.
    /// </summary>
    FirstFillPartial = 10,

    /// <summary>
    /// A fill where a small portion is provided to allow for determination of the therapy effectiveness and patient tolerance.
    /// </summary>
    TrialFill = 11,

    /// <summary>
    /// A supply action to restock a smaller more local dispensary.
    /// </summary>
    FloorStock = 12,

    /// <summary>
    /// A supply of a manufacturer sample.
    /// </summary>
    ManufacturerSample = 13,

    /// <summary>
    /// A fill against an order that has already been filled (or partially filled) at least once.
    /// </summary>
    Refill = 14,

    /// <summary>
    /// A supply action that provides sufficient material for a single dose.
    /// </summary>
    UnitDose = 15,

    /// <summary>
    /// A refill where the quantity supplied is equal to one full repetition of the ordered amount.
    /// </summary>
    RefillComplete = 16,

    /// <summary>
    /// A refill where the quantity supplied is equal to one full repetition of the ordered amount, and where the strength supplied is less than the ordered strength.
    /// </summary>
    RefillCompletePartial = 17,

    /// <summary>
    /// The first fill against an order that has already been filled at least once at another facility.
    /// </summary>
    RefillFirstFill = 18,

    /// <summary>
    /// The first fill against an order that has already been filled at least once at another facility, and where the strength supplied is less than the ordered strength.
    /// </summary>
    RefillPartialFirstFill = 19,

    /// <summary>
    /// A refill where the quantity supplied is less than one full repetition of the ordered amount.
    /// </summary>
    RefillPartFill = 20,

    /// <summary>
    /// A refill where the quantity supplied is less than one full repetition of the ordered amount, and where the strength supplied is less than the ordered strength.
    /// </summary>
    RefillPartFillPartial = 21,

    /// <summary>
    /// A fill against an order that has already been filled (or partially filled) at least once and where the strength supplied is less than the ordered strength (e.g. 10mg for an order of 50mg where a subsequent fill will dispense 40mg tablets).
    /// </summary>
    RefillPartial = 22,

    /// <summary>
    /// A fill where the remainder of a 'complete' fill is provided after a trial fill has been provided.
    /// </summary>
    TrialBalance = 23,

    /// <summary>
    /// A fill where the remainder of a 'complete' fill is provided after a trial fill has been provided and where the strength supplied is less than the ordered strength (e.g. 10mg for an order of 50mg where a subsequent fill will dispense 40mg tablets).
    /// </summary>
    TrialBalancePartial = 24,

    /// <summary>
    /// A supply action that provides sufficient material for a single dose via multiple products. E.g. 2 50mg tablets for a 100mg unit dose.
    /// </summary>
    UnitDoseEquivalent = 25
}