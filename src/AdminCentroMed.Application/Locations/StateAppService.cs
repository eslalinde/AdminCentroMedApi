using System;
using AdminCentroMed.Permissions;
using AdminCentroMed.Locations.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AdminCentroMed.Locations;

public class StateAppService : CrudAppService<State, StateDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateStateDto, CreateUpdateStateDto>,
    IStateAppService
{
    protected override string GetPolicyName { get; set; } = AdminCentroMedPermissions.State.Default;
    protected override string GetListPolicyName { get; set; } = AdminCentroMedPermissions.State.Default;
    protected override string CreatePolicyName { get; set; } = AdminCentroMedPermissions.State.Create;
    protected override string UpdatePolicyName { get; set; } = AdminCentroMedPermissions.State.Update;
    protected override string DeletePolicyName { get; set; } = AdminCentroMedPermissions.State.Delete;

    private readonly IStateRepository _repository;

    public StateAppService(IStateRepository repository) : base(repository)
    {
        _repository = repository;
    }
}
