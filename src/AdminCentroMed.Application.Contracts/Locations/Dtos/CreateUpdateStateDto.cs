using System;
using System.ComponentModel.DataAnnotations;

namespace AdminCentroMed.Locations.Dtos;

[Serializable]
public class CreateUpdateStateDto
{
    [Required]
    [StringLength(250)]
    public string Name { get; set; }

    public string NormalizeName { get; set; }

    [Required]
    public Guid CountryId { get; set; }
}