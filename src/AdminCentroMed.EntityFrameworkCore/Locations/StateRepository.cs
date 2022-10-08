using AdminCentroMed.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace AdminCentroMed.Locations;

public class StateRepository : EfCoreRepository<AdminCentroMedDbContext, State, Guid>, IStateRepository
{
    public StateRepository(IDbContextProvider<AdminCentroMedDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public async Task<IQueryable<State>> GetFilteredQueryableAsync(int skipCount, int maxResultCount, string sorting, string filter = null)
    {
        var dbContext = await GetDbContextAsync();

        return dbContext.States
            .WhereIf(
                !filter.IsNullOrWhiteSpace(),
                state => state.Name.Contains(filter)
             )
            .OrderBy(sorting)
            .Skip(skipCount)
            .Take(maxResultCount);
    }

    public override async Task<IQueryable<State>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}