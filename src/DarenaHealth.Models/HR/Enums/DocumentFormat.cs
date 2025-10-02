
namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Document Format
/// </summary>
public enum DocumentFormat
{
    /// <summary>
    /// Personal Health Records. Also known as HL7 CCD and HITSP C32
    /// </summary>
    PersonalHealthRecords = 1,

    /// <summary>
    /// IHE Antepartum Summary
    /// </summary>
    AntepartumSummary = 2,

    /// <summary>
    /// XDS Medical Summaries
    /// </summary>
    MedicalSummaries = 3,

    /// <summary>
    /// Emergency Department Referral (EDR)
    /// </summary>
    EmergencyDepartmentReferral = 4,

    /// <summary>
    /// Emergency Department Encounter Summary (EDES)
    /// </summary>
    EmergencyDepartmentEncounterSummary = 5,

    /// <summary>
    /// Antepartum Record (APR) - History and Physical
    /// </summary>
    AntepartumHistoryPhysical = 6,

    /// <summary>
    /// Antepartum Record (APR) - Laboratory
    /// </summary>
    AntepartumLaboratory = 7,

    /// <summary>
    /// Antepartum Record (APR) - Education
    /// </summary>
    AntepartumEducation = 8,

    /// <summary>
    /// Cancer Registry Content (CRC)
    /// </summary>
    CancerRegistryContent = 9,

    /// <summary>
    /// Care Management (CM)
    /// </summary>
    CareManagement = 10,

    /// <summary>
    /// Immunization Content (IC)
    /// </summary>
    ImmunizationContent = 11,

    /// <summary>
    /// PCC TN
    /// </summary>
    PccTN = 12,

    /// <summary>
    /// PCC NN
    /// </summary>
    PccNN = 13,

    /// <summary>
    /// PCC CTN
    /// </summary>
    PccCTN = 14,

    /// <summary>
    /// PCC EDPN
    /// </summary>
    PccEDPN = 15,

    /// <summary>
    /// PCC HP
    /// </summary>
    PccHP = 16,

    /// <summary>
    /// PCC LDHP
    /// </summary>
    PccLDHP = 17,

    /// <summary>
    /// PCC LDS
    /// </summary>
    PccLDS = 18,

    /// <summary>
    /// PCC MDS
    /// </summary>
    PccMDS = 19,

    /// <summary>
    /// PCC NDS
    /// </summary>
    PccNDS = 20,

    /// <summary>
    /// PCC PPVS
    /// </summary>
    PccPPVS = 21,

    /// <summary>
    /// PCC TRS
    /// </summary>
    PccTRS = 22,

    /// <summary>
    /// PCC ETS
    /// </summary>
    PccETS = 23,

    /// <summary>
    /// PCC ITS
    /// </summary>
    PccITS = 24,

    /// <summary>
    /// Routine Interfacility Patient Transport (RIPT)
    /// </summary>
    RoutineInterfacilityPatientTransport = 25,

    /// <summary>
    /// Basic Patient Privacy Consents
    /// </summary>
    BasicPatientPrivacyConsents = 26,

    /// <summary>
    /// Basic Patient Privacy Consents with Scanned Document
    /// </summary>
    BasicPatientPrivacyConsentsScannedDocument = 27,

    /// <summary>
    /// PDF embedded in CDA per XDS-SD profile
    /// </summary>
    PdfCDA = 28,

    /// <summary>
    /// Text embedded in CDA per XDS-SD profile
    /// </summary>
    TextCDA = 29,

    /// <summary>
    /// XDW Workflow Document
    /// </summary>
    XDWWorkflow = 30,

    /// <summary>
    /// DSG Detached Document
    /// </summary>
    DSGDetached = 31,

    /// <summary>
    /// DSG Enveloping Document
    /// </summary>
    DSGEnveloping = 32,

    /// <summary>
    /// Advanced Patient Privacy Consents
    /// </summary>
    AdvancedPatientPrivacyConsents = 33,

    /// <summary>
    /// mimeType Sufficient
    /// </summary>
    mimeTypeSufficient = 34,

    /// <summary>
    /// CDA Laboratory Report
    /// </summary>
    CDALaboratoryReport = 35,

    /// <summary>
    /// Radiology XDS-I Text
    /// </summary>
    RadiologyXDSText = 36,

    /// <summary>
    /// Radiology XDS-I PDF
    /// </summary>
    RadiologyXDSPDF = 37,

    /// <summary>
    /// Radiology XDS-I Structured CDA
    /// </summary>
    RadiologyXDSCDA = 38,

    /// <summary>
    /// Cardiac Imaging Report
    /// </summary>
    CardiacImagingReport = 39,

    /// <summary>
    /// Cardiology CRC
    /// </summary>
    CardiologyCRC = 40,

    /// <summary>
    /// Cardiology EPRC-IE
    /// </summary>
    CardiologyEPRCIE = 41,

    /// <summary>
    /// Dental Text
    /// </summary>
    DentalText = 42,

    /// <summary>
    /// Dental PDF
    /// </summary>
    DentalPDF = 43,

    /// <summary>
    /// Dental CDA
    /// </summary>
    DentalCDA = 44,

    /// <summary>
    /// Anatomic Pathology Structured Report All
    /// </summary>
    APSRAll = 45,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer All
    /// </summary>
    APSRCancerAll = 46,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer Breast
    /// </summary>
    APSRCancerBreast = 47,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer Colon
    /// </summary>
    APSRCancerColon = 48,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer Prostate
    /// </summary>
    APSRCancerProstate = 49,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer Thyroid
    /// </summary>
    APSRCancerThyroid = 50,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer Lung
    /// </summary>
    APSRCancerLung = 51,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer Skin
    /// </summary>
    APSRCancerSkin = 52,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer Kidney
    /// </summary>
    APSRCancerKidney = 53,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer Cervix
    /// </summary>
    APSRCancerCervix = 54,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer Endometrium
    /// </summary>
    APSRCancerEndometrium = 55,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer Ovary
    /// </summary>
    APSRCancerOvary = 56,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer Esophagus
    /// </summary>
    APSRCancerEsophagus = 57,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer Stomach
    /// </summary>
    APSRCancerStomach = 58,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer Liver
    /// </summary>
    APSRCancerLiver = 59,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer Pancreas
    /// </summary>
    APSRCancerPancreas = 60,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer Testis
    /// </summary>
    APSRCancerTestis = 61,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer Urinary Bladder
    /// </summary>
    APSRCancerUrinaryBladder = 62,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer Lip Oral Cavity
    /// </summary>
    APSRCancerLipOralCavity = 63,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer Pharynx
    /// </summary>
    APSRCancerPharynx = 64,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer Salivary Gland
    /// </summary>
    APSRCancerSalivaryGland = 65,

    /// <summary>
    /// Anatomic Pathology Structured Report Cancer Larynx
    /// </summary>
    APSRCancerLarynx = 66,

    /// <summary>
    /// Pharmacy Pre
    /// </summary>
    PharmacyPre = 67,

    /// <summary>
    /// Pharmacy PADV
    /// </summary>
    PharmacyPADV = 68,

    /// <summary>
    /// Pharmacy DIS
    /// </summary>
    PharmacyDIS = 69,

    /// <summary>
    /// Pharmacy PML
    /// </summary>
    PharmacyPML = 70,

    /// <summary>
    /// For documents following C-CDA 1.1 constraints using a structured body.
    /// </summary>
    C_CDA1d1structured = 71,

    /// <summary>
    /// For documents following C-CDA 1.1 constraints using a non structured body.
    /// </summary>
    CCDA1d1nonstructured = 72,

    /// <summary>
    /// For documents following C-CDA 2.1 constraints using a structured body.
    /// </summary>
    CCDA2d1structured = 73,

    /// <summary>
    /// For documents following C-CDA 2.1 constraints using a non structured body.
    /// </summary>
    CCDA2d1nonstructured = 74
}
