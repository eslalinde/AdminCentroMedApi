using System;

namespace AdminCentroMed.Locations.Dtos;

[Serializable]
public class CreateUpdateCountryDto
{
    public string Name { get; set; }

    public string Code { get; set; }

    public string NormalizeName { get; set; }
}