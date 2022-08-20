using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AdminCentroMed.Locations;

public static class CountryEfCoreQueryableExtensions
{
    public static IQueryable<Country> IncludeDetails(this IQueryable<Country> queryable, bool include = true)
    {
        if (!include)
        {
            return queryable;
        }

        return queryable
            // .Include(x => x.xxx) // TODO: AbpHelper generated
            ;
    }
}
