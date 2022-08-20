using System;
using AdminCentroMed.Permissions;
using AdminCentroMed.Locations.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AdminCentroMed.Locations;

public class CountryAppService : CrudAppService<Country, CountryDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCountryDto, CreateUpdateCountryDto>,
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
}
