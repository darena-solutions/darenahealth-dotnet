using System;

namespace DarenaHealth.Models.HR;

/// <summary>
/// Type for defining a date range or a single point of time
/// </summary>
public class TimeRange
{
    private DateTime _point = DateTime.MinValue;

    /// <summary>
    /// Initializes a new instance of the <see cref="TimeRange"/> class
    /// </summary>
    /// <remarks>
    /// We need this constructor because we have other constructors for this class. Thus, when
    /// deserializing from JSON, we need a default constructor
    /// </remarks>
    public TimeRange()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TimeRange"/> class
    /// </summary>
    /// <param name="startDate">The start date</param>
    public TimeRange(DateTime startDate)
    {
        StartDate = startDate;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TimeRange"/> class
    /// </summary>
    /// <param name="startDate">The start date</param>
    /// <param name="endDate">The end date</param>
    public TimeRange(DateTime startDate, DateTime endDate)
    {
        StartDate = startDate;
        EndDate = endDate;
    }

    /// <summary>
    /// Gets or sets the start Date for time range
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Gets or sets the end date for time range
    /// </summary>
    public DateTime EndDate { get; set; } = DateTime.MaxValue;

    /// <summary>
    /// Gets or sets the single date point for time range
    /// </summary>
    public DateTime Point
    {
        get => _point == DateTime.MinValue ? StartDate : _point;
        set => _point = value;
    }
}