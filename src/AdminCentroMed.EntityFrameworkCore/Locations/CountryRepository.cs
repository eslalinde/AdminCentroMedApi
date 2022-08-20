using System;
using System.Linq;
using System.Threading.Tasks;
using AdminCentroMed.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace AdminCentroMed.Locations;

public class CountryRepository : EfCoreRepository<AdminCentroMedDbContext, Country, Guid>, ICountryRepository
{
    public CountryRepository(IDbContextProvider<AdminCentroMedDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Country>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}