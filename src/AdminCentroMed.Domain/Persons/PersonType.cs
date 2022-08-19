using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace AdminCentroMed.Persons
{
    public class PersonType : Entity<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; set; }
        public Enums.PersonType PersonTypeId { get; set; }
        public string Name { get; set; }

        protected PersonType()
        {
        }

        public PersonType(
            Guid id,
            Guid? tenantId,
            Enums.PersonType personTypeId,
            string name
        ) : base(id)
        {
            TenantId = tenantId;
            PersonTypeId = personTypeId;
            Name = name;
        }
    }
}