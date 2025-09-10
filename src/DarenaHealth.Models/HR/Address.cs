using System;
using System.Collections.Generic;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model that represents an address
/// </summary>
public class Address
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Address"/> class
    /// </summary>
    public Address()
    {
        StreetLines = new List<string>();
    }

    /// <summary>
    /// Gets or sets the list of address lines
    /// </summary>
    public List<string> StreetLines { get; set; }

    /// <summary>
    /// Gets or sets the address city
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// Gets or sets the address state
    /// </summary>
    public string State { get; set; }

    /// <summary>
    /// Gets or sets the address zip code
    /// </summary>
    public string Zip { get; set; }

    /// <summary>
    /// Gets or sets the address country
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// Gets or sets the address use
    /// </summary>
    public string Use { get; set; }

    /// <summary>
    /// Gets or sets the date this address was in use
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Gets or sets the date this address is invalid
    /// </summary>
    public DateTime EndDate { get; set; }
}