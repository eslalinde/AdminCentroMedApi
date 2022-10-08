using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace AdminCentroMed.Locations;

public interface IStateRepository : IRepository<State, Guid>
{
    Task<IQueryable<State>> GetFilteredQueryableAsync(
            int skipCount,
            int maxResultCount,
            string sorting,
            string filter = null);
}