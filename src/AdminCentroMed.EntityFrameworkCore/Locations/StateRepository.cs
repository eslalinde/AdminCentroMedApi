using System;
using System.Linq;
using System.Threading.Tasks;
using AdminCentroMed.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace AdminCentroMed.Locations;

public class StateRepository : EfCoreRepository<AdminCentroMedDbContext, State, Guid>, IStateRepository
{
    public StateRepository(IDbContextProvider<AdminCentroMedDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<State>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}