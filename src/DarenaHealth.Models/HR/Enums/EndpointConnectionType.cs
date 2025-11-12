namespace DarenaSolutions.MyMipsScore.Core.Enums
{
    /// <summary>
    /// Endpoint Connection Type
    /// http://terminology.hl7.org/CodeSystem/endpoint-connection-type
    /// </summary>
    public enum EndpointConnectionType
    {
        /// <summary>
        /// IHE Cross Community Patient Discovery Profile (XCPD) - http://wiki.ihe.net/index.php/Cross-Community_Patient_Discovery
        /// </summary>
        IheXcpd = 0,

        /// <summary>
        /// IHE Cross Community Access Profile (XCA) - http://wiki.ihe.net/index.php/Cross-Community_Access
        /// </summary>
        IheXca = 1,

        /// <summary>
        /// IHE Cross-Enterprise Document Reliable Exchange (XDR) - http://wiki.ihe.net/index.php/Cross-enterprise_Document_Reliable_Interchange
        /// </summary>
        IheXdr = 2,

        /// <summary>
        /// IHE Cross-Enterprise Document Sharing (XDS) - http://wiki.ihe.net/index.php/Cross-Enterprise_Document_Sharing
        /// </summary>
        IheXds = 3,

        /// <summary>
        /// IHE Invoke Image Display (IID) - http://wiki.ihe.net/index.php/Invoke_Image_Display
        /// </summary>
        IheIid = 4,

        /// <summary>
        /// DICOMweb RESTful Image Retrieve - http://dicom.nema.org/medical/dicom/current/output/chtml/part18/sect_6.5.html
        /// </summary>
        DicomWadoRs = 5,

        /// <summary>
        /// DICOMweb RESTful Image query - http://dicom.nema.org/medical/dicom/current/output/chtml/part18/sect_6.7.html
        /// </summary>
        DicomQidoRs = 6,

        /// <summary>
        /// DICOMweb RESTful image sending and storage - http://dicom.nema.org/medical/dicom/current/output/chtml/part18/sect_6.6.html
        /// </summary>
        DicomStowRs = 7,

        /// <summary>
        /// DICOMweb Image Retrieve - http://dicom.nema.org/dicom/2013/output/chtml/part18/sect_6.3.html
        /// </summary>
        DicomWadoUri = 8,

        /// <summary>
        /// Interact with the server interface using FHIR's RESTful interface. For details on its version/capabilities you should connect the value in Endpoint.address and retrieve the FHIR CapabilityStatement.
        /// </summary>
        Hl7FhirRest = 9,

        /// <summary>
        /// Use the servers FHIR Messaging interface. Details can be found on the messaging.html page in the FHIR Specification. The FHIR server's base address is specified in the Endpoint.address property.
        /// </summary>
        Hl7FhirMsg = 10,

        /// <summary>
        /// HL7v2 messages over an LLP TCP connection.
        /// </summary>
        Hl7v2Mllp = 11,

        /// <summary>
        /// Email delivery using a digital certificate to encrypt the content using the public key, receiver must have the private key to decrypt the content.
        /// </summary>
        SecureEmail = 12,

        /// <summary>
        /// Direct Project information - http://wiki.directproject.org/
        /// </summary>
        DirectProject = 13
    }
}