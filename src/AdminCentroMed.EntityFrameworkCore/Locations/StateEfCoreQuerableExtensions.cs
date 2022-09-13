using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AdminCentroMed.Locations;

public static class StateEfCoreQueryableExtensions
{
    public static IQueryable<State> IncludeDetails(this IQueryable<State> queryable, bool include = true)
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
