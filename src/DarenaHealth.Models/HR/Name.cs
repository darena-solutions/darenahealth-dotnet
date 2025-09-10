using System.Collections.Generic;
using System.Linq;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model that represents the name of an entity
/// </summary>
public class Name
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Name"/> class
    /// </summary>
    public Name()
    {
        Prefixes = new List<string>();
        MiddleNames = new List<string>();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Name"/> class
    /// </summary>
    /// <param name="firstName">The first name</param>
    /// <param name="lastName">The last name</param>
    public Name(string firstName, string lastName)
        : this()
    {
        First = firstName;
        Last = lastName;
    }

    /// <summary>
    /// Gets or sets the prefixes for the names
    /// </summary>
    public List<string> Prefixes { get; set; }

    /// <summary>
    /// Gets or sets the suffix for the name
    /// </summary>
    public string Suffix { get; set; }

    /// <summary>
    /// Gets or sets the last name
    /// </summary>
    public string Last { get; set; }

    /// <summary>
    /// Gets or sets the first name
    /// </summary>
    public string First { get; set; }

    /// <summary>
    /// Gets or sets the list of middle names
    /// </summary>
    public List<string> MiddleNames { get; set; }

    /// <summary>
    /// Gets or sets the time period for the Name
    /// </summary>
    public TimeRange Period { get; set; }

    /// <summary>
    /// Gets the full name derived by combining the prefixes, last name,
    /// first name, and middle names
    /// </summary>
    public string FullName
    {
        get
        {
            var list = new List<string>();
            if (Prefixes != null && Prefixes.Any())
                list.AddRange(Prefixes);

            if (!string.IsNullOrWhiteSpace(First))
                list.Add(First);

            if (MiddleNames != null && MiddleNames.Any())
                list.AddRange(MiddleNames);

            if (!string.IsNullOrWhiteSpace(Last))
                list.Add(Last);

            return list.Any() ? string.Join(" ", list) : null;
        }
    }
}