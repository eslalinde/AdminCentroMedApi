using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace AdminCentroMed.Locations;

public class City : Entity<Guid>, IMultiTenant
{
    public Guid? TenantId { get; set; }

    public string Name { get; set; }

    public string NormalizeName { get; set; }

    public Guid StateId { get; set; }

    public Guid CountryId { get; set; }

    protected City()
    {
    }

    public City(
        Guid id,
        Guid? tenantId,
        string name,
        Guid stateId,
        Guid countryId,
        string normalizeName = default
    ) : base(id)
    {
        TenantId = tenantId;
        Name = name;
        NormalizeName = normalizeName;
        StateId = stateId;
        CountryId = countryId;

        NormalizeName = normalizeName ?? name.NormalizeString();
    }
}