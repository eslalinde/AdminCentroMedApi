using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace AdminCentroMed.Parishs
{
    public class ParishTeam : Entity<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; set; }
        public Guid ParishId { get; set; }
        public Guid TeamId { get; set; }

        protected ParishTeam()
        {
        }

        public ParishTeam(
            Guid id,
            Guid? tenantId,
            Guid parishId,
            Guid teamId
        ) : base(id)
        {
            TenantId = tenantId;
            ParishId = parishId;
            TeamId = teamId;
        }
    }
}