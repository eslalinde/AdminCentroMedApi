using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace AdminCentroMed.Parishs;

public class Parish : Entity<Guid>, IMultiTenant
{
    public Guid? TenantId { get; set; }
    public string Name { get; set; }
    public string NormalizedName { get; set; }
    public string Diocese { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public Guid CityId { get; set; }

    //public ICollection<ParishTeam> Teams { get; set; }
    //public ICollection<Priest> Priests { get; set; }
    //public ICollection<Community> Communities { get; set; }

    protected Parish()
    {
    }

    public Parish(
        Guid id,
        Guid? tenantId,
        string name,
        string diocese,
        string address,
        string phone,
        string email,
        Guid cityId,
        string normalizeName
    ) : base(id)
    {
        TenantId = tenantId;
        Name = name;
        Diocese = diocese;
        Address = address;
        Phone = phone;
        Email = email;
        CityId = cityId;

        NormalizedName = normalizeName ?? name.NormalizeString();
    }
}