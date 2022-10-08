using AdminCentroMed.Locations.Dtos;
using AdminCentroMed.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AdminCentroMed.Locations;

public class StateAppService : CrudAppService<State, StateDto, Guid, FilterResultRequestDto, CreateUpdateStateDto, CreateUpdateStateDto>,
    IStateAppService
{
    protected override string GetPolicyName { get; set; } = AdminCentroMedPermissions.State.Default;
    protected override string GetListPolicyName { get; set; } = AdminCentroMedPermissions.State.Default;
    protected override string CreatePolicyName { get; set; } = AdminCentroMedPermissions.State.Create;
    protected override string UpdatePolicyName { get; set; } = AdminCentroMedPermissions.State.Update;
    protected override string DeletePolicyName { get; set; } = AdminCentroMedPermissions.State.Delete;

    private readonly IStateRepository _stateRepository;
    private readonly ICountryRepository _countryRepository;

    public StateAppService(IStateRepository repository, ICountryRepository countryRepository) : base(repository)
    {
        _stateRepository = repository;
        _countryRepository = countryRepository;
    }

    public override async Task<PagedResultDto<StateDto>> GetListAsync(FilterResultRequestDto input)
    {
        var queryable = await Repository.GetQueryableAsync();

        var query = from state in queryable
                    join country in await _countryRepository.GetQueryableAsync() on state.CountryId equals country.Id
                    select new { state, country.Name };

        query = query
            .OrderBy(NormalizeSorting(input.Sorting))
            .Skip(input.SkipCount)
            .Take(input.MaxResultCount);

        var queryResult = await AsyncExecuter.ToListAsync(query);

        var stateDtos = queryResult.Select(x =>
        {
            var bookDto = ObjectMapper.Map<State, StateDto>(x.state);
            bookDto.CountryName = x.Name;
            return bookDto;
        }).ToList();

        var totalCount = await Repository.GetCountAsync();

        return new PagedResultDto<StateDto>(
            totalCount,
            stateDtos
        );
    }

    public async Task<ListResultDto<StateLookupDto>> GetStateLookupAsync()
    {
        var states = await _stateRepository.GetListAsync();

        return new ListResultDto<StateLookupDto>(
            ObjectMapper.Map<List<State>, List<StateLookupDto>>(states)
        );
    }

    private static string NormalizeSorting(string sorting)
    {
        if (sorting.IsNullOrEmpty())
        {
            return $"state.{nameof(State.Name)}";
        }

        if (sorting.Contains("countryName", StringComparison.OrdinalIgnoreCase))
        {
            return sorting.Replace(
                "countryName",
                "country.Name",
                StringComparison.OrdinalIgnoreCase
            );
        }

        return $"state.{sorting}";
    }
}