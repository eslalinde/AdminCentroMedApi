using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace AdminCentroMed.Teams
{
    public class TeamType : Entity<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public int Order { get; set; }

        protected TeamType()
        {
        }

        public TeamType(
            Guid id,
            Guid? tenantId,
            string name,
            string normalizedName,
            int order
        ) : base(id)
        {
            TenantId = tenantId;
            Name = name;
            NormalizedName = normalizedName;
            Order = order;
        }
    }
}