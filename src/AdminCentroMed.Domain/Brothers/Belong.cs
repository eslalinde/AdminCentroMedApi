using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace AdminCentroMed.Brothers
{
    public class Belong : Entity<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; set; }
        public Guid BrotherId { get; set; }
        public Guid TeamId { get; set; }
        public bool IsResponsibleForTheTeam { get; set; }

        protected Belong()
        {
        }

        public Belong(
            Guid id,
            Guid? tenantId,
            Guid brotherId,
            Guid teamId,
            bool isResponsibleForTheTeam
        ) : base(id)
        {
            TenantId = tenantId;
            BrotherId = brotherId;
            TeamId = teamId;
            IsResponsibleForTheTeam = isResponsibleForTheTeam;
        }
    }
}