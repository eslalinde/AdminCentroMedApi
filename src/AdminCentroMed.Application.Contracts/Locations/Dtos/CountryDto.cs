using System;
using Volo.Abp.Application.Dtos;

namespace AdminCentroMed.Locations.Dtos;

[Serializable]
public class CountryDto : EntityDto<Guid>
{
    public string Name { get; set; }

    public string Code { get; set; }

    public string NormalizeName { get; set; }
}