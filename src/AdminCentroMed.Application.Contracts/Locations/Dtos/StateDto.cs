using System;
using Volo.Abp.Application.Dtos;

namespace AdminCentroMed.Locations.Dtos;

[Serializable]
public class StateDto : EntityDto<Guid>
{
    public string Name { get; set; }

    public string NormalizeName { get; set; }

    public Guid CountryId { get; set; }

    public string CountryName { get; set; }
}