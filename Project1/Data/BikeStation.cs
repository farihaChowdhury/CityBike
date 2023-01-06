using System;
using System.Collections.Generic;

namespace CityBike.Data;

public partial class BikeStation
{
    public int Fid { get; set; }

    public int Id { get; set; }

    public string? Nimi { get; set; }

    public string? Namn { get; set; }

    public string? Name { get; set; }

    public string? Osoite { get; set; }

    public string? Address { get; set; }

    public string? Kaupunki { get; set; }

    public string? Stad { get; set; }

    public string? Operaattor { get; set; }

    public string? Kapasiteet { get; set; }

    public double? X { get; set; }

    public double? Y { get; set; }
}
