using System;
using Volo.Abp.Domain.Repositories;

namespace AdminCentroMed.Locations;

public interface ICountryRepository : IRepository<Country, Guid>
{
}
