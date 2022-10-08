using System;
using Volo.Abp.Application.Dtos;

namespace AdminCentroMed.Locations.Dtos
{
    public class CountryLookupDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}