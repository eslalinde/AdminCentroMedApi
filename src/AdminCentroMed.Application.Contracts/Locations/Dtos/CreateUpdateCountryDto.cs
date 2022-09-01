using System;
using System.ComponentModel.DataAnnotations;

namespace AdminCentroMed.Locations.Dtos;

[Serializable]
public class CreateUpdateCountryDto
{
    [Required]
    [StringLength(250)]
    public string Name { get; set; }

    [Required]
    [StringLength(2)]
    public string Code { get; set; }

    public string NormalizeName { get; set; }
}