using System.Collections.Generic;
using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// a class that represents a code value
/// </summary>
public class CodeValue
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CodeValue"/> class
    /// </summary>
    public CodeValue()
    {
        Translations = new List<CodeValue>();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CodeValue"/> class
    /// </summary>
    /// <param name="code">The coded entry's code</param>
    public CodeValue(string code)
        : this()
    {
        Code = code;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CodeValue"/> class
    /// </summary>
    /// <param name="code">The coded entry's code</param>
    /// <param name="displayName">The coded entry's display text</param>
    /// <param name="modifier">The coded entry's modifier</param>
    public CodeValue(string code, string displayName, string modifier = null)
        : this()
    {
        DisplayName = displayName;
        Code = code;
        Modifier = modifier;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CodeValue"/> class
    /// </summary>
    /// <param name="code">The coded entry's code</param>
    /// <param name="displayName">The coded entry's display text</param>
    /// <param name="codingSystem">The coding system this entry uses</param>
    /// <param name="nullFlavor">The entry's null flavor value</param>
    public CodeValue(string code, string displayName, CodingSystem codingSystem, string nullFlavor = null)
        : this()
    {
        DisplayName = displayName;
        Code = code;
        System = codingSystem;
        NullFlavor = nullFlavor;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CodeValue"/> class
    /// </summary>
    /// <param name="code">The coded entry's code</param>
    /// <param name="codingSystem">The coding system this entry uses</param>
    public CodeValue(string code, CodingSystem codingSystem)
        : this()
    {
        Code = code;
        System = codingSystem;
    }

    /// <summary>
    /// Gets or sets the coded entry's modifier
    /// </summary>
    public string Modifier { get; set; }

    /// <summary>
    /// Gets or sets the coded entry's display text
    /// </summary>
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or sets the coded entry's code
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the coding system this entry users
    /// </summary>
    public CodingSystem? System { get; set; }

    /// <summary>
    /// Gets or sets the list of translation concept codes for this entry
    /// </summary>
    public List<CodeValue> Translations { get; set; }

    /// <summary>
    /// Gets or sets the entry's null flavor value
    /// </summary>
    public string NullFlavor { get; set; }

    /// <summary>
    /// Gets or sets the entry's stdc value set
    /// </summary>
    public string StdcValueSet { get; set; }
}