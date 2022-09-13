using System;
using AdminCentroMed.Locations.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AdminCentroMed.Locations;

public interface IStateAppService :
    ICrudAppService< 
        StateDto, 
        Guid, 
        PagedAndSortedResultRequestDto,
        CreateUpdateStateDto,
        CreateUpdateStateDto>
{

}