using AdminCentroMed.Enums;
using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace AdminCentroMed.Locations
{
    public class State : Entity<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; set; }

        public string Name { get; set; }

        public string NormalizeName { get; set; }

        public Guid CountryId { get; set; }

        protected State()
        {
        }

        public State(
            Guid id,
            Guid? tenantId,
            string name,
            Guid countryId,
            string normalizeName = default
        ) : base(id)
        {
            TenantId = tenantId;
            Name = name;
            CountryId = countryId;

            NormalizeName = normalizeName ?? name.NormalizeString();
        }
    }
}