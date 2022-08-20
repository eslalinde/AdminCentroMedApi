using System;
using AdminCentroMed.Locations.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AdminCentroMed.Locations;

public interface ICountryAppService :
    ICrudAppService< 
        CountryDto, 
        Guid, 
        PagedAndSortedResultRequestDto,
        CreateUpdateCountryDto,
        CreateUpdateCountryDto>
{

}