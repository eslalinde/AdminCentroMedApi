using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace AdminCentroMed.Priests;

public class Priest : Entity<Guid>, IMultiTenant
{
    public Guid? TenantId { get; set; }
    public Guid PersonId { get; set; }
    public Guid ParishId { get; set; }
    public bool IsParishPriest { get; set; }

    protected Priest()
    {
    }

    public Priest(
        Guid id,
        Guid? tenantId,
        Guid personId,
        Guid parishId,
        bool isParishPriest
    ) : base(id)
    {
        TenantId = tenantId;
        PersonId = personId;
        ParishId = parishId;
        IsParishPriest = isParishPriest;
    }
}