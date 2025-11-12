namespace DarenaSolutions.MyMipsScore.Core.Enums
{
    /// <summary>
    /// Endpoint Status
    /// http://hl7.org/fhir/endpoint-status
    /// </summary>
    public enum EndpointStatus
    {
        /// <summary>
        /// This endpoint is expected to be active and can be used.
        /// </summary>
        Active = 0,

        /// <summary>
        /// This endpoint is temporarily unavailable.
        /// </summary>
        Suspended = 1,

        /// <summary>
        /// This endpoint has exceeded connectivity thresholds and is considered in an error state and should no longer be attempted to connect to until corrective action is taken.
        /// </summary>
        Error = 2,

        /// <summary>
        /// This endpoint is no longer to be used.
        /// </summary>
        Off = 3,

        /// <summary>
        /// This instance should not have been part of this patient's medical record.
        /// </summary>
        EnteredInError = 4,

        /// <summary>
        /// This endpoint is not intended for production usage.
        /// </summary>
        Test = 5,
    }
}
