using AdminCentroMed.Locations.Dtos;
using AdminCentroMed.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AdminCentroMed.Locations;

public class CountryAppService : CrudAppService<Country, CountryDto, Guid, FilterResultRequestDto, CreateUpdateCountryDto, CreateUpdateCountryDto>,
    ICountryAppService
{
    protected override string GetPolicyName { get; set; } = AdminCentroMedPermissions.Country.Default;
    protected override string GetListPolicyName { get; set; } = AdminCentroMedPermissions.Country.Default;
    protected override string CreatePolicyName { get; set; } = AdminCentroMedPermissions.Country.Create;
    protected override string UpdatePolicyName { get; set; } = AdminCentroMedPermissions.Country.Update;
    protected override string DeletePolicyName { get; set; } = AdminCentroMedPermissions.Country.Delete;

    private readonly ICountryRepository _repository;

    public CountryAppService(ICountryRepository repository) : base(repository)
    {
        _repository = repository;
    }

    public override async Task<PagedResultDto<CountryDto>> GetListAsync(FilterResultRequestDto input)
    {
        var queryable = await Repository.GetQueryableAsync();

        queryable = queryable
            .OrderBy(NormalizeSorting(input.Sorting))
            .Skip(input.SkipCount)
            .Take(input.MaxResultCount);

        var queryResult = await AsyncExecuter.ToListAsync(queryable);
        var countryDto = ObjectMapper.Map<List<Country>, List<CountryDto>>(queryResult);

        var totalCount = await Repository.GetCountAsync();

        return new PagedResultDto<CountryDto>(
            totalCount,
            countryDto
        );
    }

    public async Task<ListResultDto<CountryLookupDto>> GetCountryLookupAsync()
    {
        var countries = await _repository.GetListAsync();

        return new ListResultDto<CountryLookupDto>(
            ObjectMapper.Map<List<Country>, List<CountryLookupDto>>(countries)
        );
    }

    private static string NormalizeSorting(string sorting)
    {
        if (sorting.IsNullOrEmpty())
        {
            return $"country.{nameof(Country.Name)}";
        }

        return $"country.{sorting}";
    }
}