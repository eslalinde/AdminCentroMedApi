using AdminCentroMed.Locations.Dtos;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AdminCentroMed.Locations;

public interface ICountryAppService :
    ICrudAppService<
        CountryDto,
        Guid,
        FilterResultRequestDto,
        CreateUpdateCountryDto,
        CreateUpdateCountryDto>
{
    Task<ListResultDto<CountryLookupDto>> GetCountryLookupAsync();
}