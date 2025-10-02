namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// All coding system based on CEHRT specifications
/// </summary>
public enum CodingSystem
{
    /// <summary>
    /// The value is an ICD10 code
    /// </summary>
    Icd10 = 0,

    /// <summary>
    /// The value is a payer
    /// </summary>
    Payer = 1,

    /// <summary>
    /// The value is a CPT4 code
    /// </summary>
    Cpt4 = 2,

    /// <summary>
    /// A value for language ability proficiency
    /// </summary>
    LanguageAbilityProficiency = 3,

    /// <summary>
    /// A value for language ability mode
    /// </summary>
    LanguageAbilityMode = 4,

    /// <summary>
    /// A marital status value
    /// </summary>
    MaritalStatus = 5,

    /// <summary>
    /// A CDC race/ethnicity value
    /// </summary>
    CdcRaceEthnicity = 6,

    /// <summary>
    /// An HL7 administrative gender value
    /// </summary>
    Hl7AdministrativeGender = 7,

    /// <summary>
    /// A SNOMED value
    /// </summary>
    Snomed = 8,

    /// <summary>
    /// A LOINC value
    /// </summary>
    Loinc = 9,

    /// <summary>
    /// A value for NUCC HealthCare provider taxonomy
    /// </summary>
    NuccHealthCareProviderTaxonomy = 10,

    /// <summary>
    /// A census occupation code value
    /// </summary>
    CensusOccupationCode = 11,

    /// <summary>
    /// A census industry code value
    /// </summary>
    CensusIndustryCode = 12,

    /// <summary>
    /// The value is an ICD03 code
    /// </summary>
    Icd03 = 13,

    /// <summary>
    /// The value is an NAACCR behavior code
    /// </summary>
    NaaCcrBehaviorCode = 14,

    /// <summary>
    /// A value for NACR diagnostic confirmation
    /// </summary>
    NacrDiagnosticConfirmation = 15,

    /// <summary>
    /// The value is an ICD9CM code
    /// </summary>
    Icd9Cm = 16,

    /// <summary>
    /// A value for NAACCR laterality at diagnosis
    /// </summary>
    NaaCcrLateralityAtDiagnosis = 17,

    /// <summary>
    /// A value for NAACCR TNM clinical stage group
    /// </summary>
    NaaCcrTnmClinicalStageGroup = 18,

    /// <summary>
    /// A value for NAACCR TNM clinical stage descriptor
    /// </summary>
    NaaCcrTnmClinicalStageDescriptor = 19,

    /// <summary>
    /// A value for NAACCR TNM edition number
    /// </summary>
    NaaCcrTnmEditionNumber = 20,

    /// <summary>
    /// A value for TNM clinical staging
    /// </summary>
    TnmClinicalStagedBy = 21,

    /// <summary>
    /// A value for NAACCR TNM clinical tumor
    /// </summary>
    NaaCcrTnmClinicalTumor = 22,

    /// <summary>
    /// A value for NAACCR TNM clinical node
    /// </summary>
    NaaCcrTnmClinicalNode = 23,

    /// <summary>
    /// A value for NAACCR TNM clinical metastasis
    /// </summary>
    NaaCcrTnmClinicalMetastasis = 24,

    /// <summary>
    /// A value for HL7 confidentiality
    /// </summary>
    Hl7Confidentiality = 25,

    /// <summary>
    /// The value is an ACT code
    /// </summary>
    ActCode = 26,

    /// <summary>
    /// The value is an observation
    /// </summary>
    ObservationValue = 27,

    /// <summary>
    /// A value for the observation method
    /// </summary>
    ObservationMethod = 28,

    /// <summary>
    /// A value for a Yes/No indicator
    /// </summary>
    YesNoIndicator = 29,

    /// <summary>
    /// The value is an ACT class code
    /// </summary>
    ActClass = 30,

    /// <summary>
    /// The value is a race code
    /// </summary>
    Race = 31,

    /// <summary>
    /// The value is an ethnicity code
    /// </summary>
    Ethnicity = 32,

    /// <summary>
    /// The value does not have a specific type
    /// </summary>
    NotSpecified = 33,

    /// <summary>
    /// The value is an RXNorm code
    /// </summary>
    RxNorm = 34,

    /// <summary>
    /// The value is a CVX code
    /// </summary>
    Cvx = 35,

    /// <summary>
    /// A value for an NCI thesaurus
    /// </summary>
    NciThesaurus = 36,

    /// <summary>
    /// The Code on Dental Procedures and Nomenclature http://www.ada.org/cdt
    /// </summary>
    Cdt = 37,

    /// <summary>
    /// http://terminology.hl7.org/CodeSystem/v3-ParticipationType
    /// </summary>
    ParticipationTypeV3 = 38,

    /// <summary>
    /// http://terminology.hl7.org/CodeSystem/participant-type
    /// </summary>
    ParticipationType = 39,

    /// <summary>
    /// https://terminology.hl7.org/5.0.0/CodeSystem-v3-ietf3066.html
    /// </summary>
    Bcp47 = 40,

    /// <summary>
    /// http://terminology.hl7.org/CodeSystem/v3-TribalEntityUS
    /// </summary>
    TribalAffiliation = 41,

    /// <summary>
    /// http://hl7.org/fhir/us/core/CodeSystem/careplan-category
    /// </summary>
    CarePlanCategory = 42,

    /// <summary>
    /// http://terminology.hl7.org/CodeSystem/PHOccupationalDataForHealthODH
    /// </summary>
    PHOccupationalDataForHealthODH = 43,

    /// <summary>
    /// Related Person Relationship Code System
    /// http://terminology.hl7.org/CodeSystem/v3-RoleCode
    /// </summary>
    RelatedPersonRole = 44,

    /// <summary>
    /// http://terminology.hl7.org/CodeSystem/v2-0074
    /// </summary>
    DiagnosticService = 45,

    /// <summary>
    /// https://nahdo.org/sopt (2.16.840.1.113883.3.221.5)
    /// </summary>
    CoverageType = 46,

    /// <summary>
    /// http://hl7.org/fhir/sid/us-npi
    /// </summary>
    Npi = 48,

    /// <summary>
    /// Related Person Relationship Code System
    /// http://terminology.hl7.org/CodeSystem/v2-0131
    /// </summary>
    RelatedPersonRoleV2 = 49,

    /// <summary>
    /// Location Type
    /// http://terminology.hl7.org/CodeSystem/hsloc
    /// </summary>
    Hsloc = 50,

    /// <summary>
    /// ActReason - Immunization
    /// http://terminology.hl7.org/CodeSystem/v3-ActReason
    /// </summary>
    ActReason = 51,
}
