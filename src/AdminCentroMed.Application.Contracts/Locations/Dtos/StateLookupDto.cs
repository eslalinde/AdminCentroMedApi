using System;
using Volo.Abp.Application.Dtos;

namespace AdminCentroMed.Locations.Dtos
{
    public class StateLookupDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}