using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace AdminCentroMed.Communities
{
    public class Community : Entity<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; set; }
        public string Number { get; set; }
        public DateTime BornDate { get; set; }
        public Guid ParishId { get; set; }
        public int BornBrothers { get; set; }
        public int ActualBrothers { get; set; }
        public Guid StepWayId { get; set; }
        public DateTime? StepWayDate { get; set; }
        public Guid? CatechistTeamId { get; set; }
        public string OldCatechist { get; set; }

        protected Community()
        {
        }

        public Community(
            Guid id,
            Guid? tenantId,
            string number,
            DateTime bornDate,
            Guid parishId,
            int bornBrothers,
            int actualBrothers,
            Guid stepWayId,
            DateTime? stepWayDate,
            Guid? catechistTeamId,
            string oldCatechist
        ) : base(id)
        {
            TenantId = tenantId;
            Number = number;
            BornDate = bornDate;
            ParishId = parishId;
            BornBrothers = bornBrothers;
            ActualBrothers = actualBrothers;
            StepWayId = stepWayId;
            StepWayDate = stepWayDate;
            CatechistTeamId = catechistTeamId;
            OldCatechist = oldCatechist;
        }
    }
}