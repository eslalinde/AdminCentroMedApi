using AdminCentroMed.Enums;
using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace AdminCentroMed.Persons;

public class Person : Entity<Guid>, IMultiTenant
{
    public Guid? TenantId { get; set; }
    public string PersonName { get; set; }
    public string Phone { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
    public Guid? SpouseId { get; set; }
    public Guid PersonTypeId { get; set; }
    public GenderType Gender { get; set; }
    public string NormalizeName { get; set; }

    protected Person()
    {
    }

    public Person(
        Guid id,
        Guid? tenantId,
        string personName,
        string phone,
        string mobile,
        string email,
        Guid? spouseId,
        Guid personTypeId,
        GenderType gender,
        string normalizeName = default
    ) : base(id)
    {
        TenantId = tenantId;
        PersonName = personName;
        Phone = phone;
        Mobile = mobile;
        Email = email;
        SpouseId = spouseId;
        PersonTypeId = personTypeId;
        Gender = gender;
        NormalizeName = normalizeName ?? personName.NormalizeString();
    }
}