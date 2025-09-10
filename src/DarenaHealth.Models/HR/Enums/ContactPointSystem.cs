namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// ContactPoint System values
/// https://hl7.org/fhir/R4/valueset-contact-point-system.html
/// </summary>
public enum ContactPointSystem
{
    /// <summary>
    /// The value is a telephone number used for voice calls. Use of full international numbers starting with + is recommended to enable automatic dialing support but not required.	
    /// </summary>
    Phone = 0,

    /// <summary>
    /// The value is a fax machine. Use of full international numbers starting with + is recommended to enable automatic dialing support but not required.
    /// </summary>
    Fax = 1,

    /// <summary>
    /// The value is an email address.
    /// </summary>
    Email = 2,

    /// <summary>
    /// The value is a pager number. These may be local pager numbers that are only usable on a particular pager system.
    /// </summary>
    Pager = 3,

    /// <summary>
    /// A contact that is not a phone, fax, pager or email address and is expressed as a URL. This is intended for various institutional or personal contacts including web sites, blogs, Skype, Twitter, Facebook, etc. Do not use for email addresses.
    /// </summary>
    Url = 4,
        
    /// <summary>
    /// A contact that can be used for sending an sms message (e.g. mobile phones, some landlines).
    /// </summary>
    Sms = 5,
        
    /// <summary>
    /// A contact that is not a phone, fax, page or email address and is not expressible as a URL. E.g. Internal mail address. This SHOULD NOT be used for contacts that are expressible as a URL (e.g. Skype, Twitter, Facebook, etc.) Extensions may be used to distinguish "other" contact types.
    /// </summary>
    Other = 6,
}