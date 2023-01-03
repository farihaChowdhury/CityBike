using System;
using System.Collections.Generic;

namespace CityBike.Data;

public partial class Journey
{
    public DateTime? DepartureDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public int? DepartureStationId { get; set; }

    public string? DepartureStationName { get; set; }

    public int? ReturnStationId { get; set; }

    public string? ReturnStationName { get; set; }

    public double? CoveredDistance { get; set; }

    public int? Duration { get; set; }
}
