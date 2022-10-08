using System;
using System.Threading.Tasks;
using AdminCentroMed.Locations.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AdminCentroMed.Locations;

public interface IStateAppService :
    ICrudAppService<
        StateDto,
        Guid,
        FilterResultRequestDto,
        CreateUpdateStateDto,
        CreateUpdateStateDto>
{
    Task<ListResultDto<StateLookupDto>> GetStateLookupAsync();
}