using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace AdminCentroMed.Teams;

public class Team : Entity<Guid>, IMultiTenant
{
    public Guid? TenantId { get; set; }
    public string Name { get; set; }
    public Guid TeamTypeId { get; set; }
    public Guid? CommunityId { get; set; }

    protected Team()
    {
    }

    public Team(
        Guid id,
        Guid? tenantId,
        string name,
        Guid teamTypeId,
        Guid? communityId
    ) : base(id)
    {
        TenantId = tenantId;
        Name = name;
        TeamTypeId = teamTypeId;
        CommunityId = communityId;
    }
}