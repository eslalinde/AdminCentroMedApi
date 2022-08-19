using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace AdminCentroMed.Brothers;

public class Brother : Entity<Guid>, IMultiTenant
{
    public Guid? TenantId { get; set; }
    public Guid PersonId { get; set; }
    public Guid CommunityId { get; set; }

    protected Brother()
    {
    }

    public Brother(
        Guid id,
        Guid? tenantId,
        Guid personId,
        Guid communityId
    ) : base(id)
    {
        TenantId = tenantId;
        PersonId = personId;
        CommunityId = communityId;
    }
}