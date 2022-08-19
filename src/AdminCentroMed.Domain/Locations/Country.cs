using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace AdminCentroMed.Locations;

public class Country : Entity<Guid>, IMultiTenant
{
    public Guid? TenantId { get; set; }

    public string Name { get; set; }

    public string Code { get; set; }

    public string NormalizeName { get; set; }

    protected Country()
    {
    }

    public Country(
        Guid id,
        Guid? tenantId,
        string name,
        string code,
        string normalizeName = default
    ) : base(id)
    {
        TenantId = tenantId;
        Name = name;
        Code = code;
        NormalizeName = normalizeName ?? name.NormalizeString();
    }
}