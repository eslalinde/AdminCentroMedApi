using System;
using Volo.Abp.Domain.Repositories;

namespace AdminCentroMed.Locations;

public interface IStateRepository : IRepository<State, Guid>
{
}
