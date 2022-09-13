using AdminCentroMed.Locations;
using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;

namespace AdminCentroMed.Seed
{
    public partial class LocationDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Country, Guid> _countryRepository;

        //private readonly IRepository<State, Guid> _stateRepository;
        //private readonly IRepository<City, Guid> _cityRepository;
        private readonly IGuidGenerator _guidGenerator;

        public LocationDataSeederContributor(
            IRepository<Country, Guid> countryRepository,
            //IRepository<State, Guid> stateRepository,
            //IRepository<City, Guid> cityRepository,
            IGuidGenerator guidGenerator)
        {
            _countryRepository = countryRepository;
            //_stateRepository = stateRepository;
            //_cityRepository = cityRepository;
            _guidGenerator = guidGenerator;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            await SeedLocationInternalAsync(context.TenantId);
        }

        public async Task SeedLocationInternalAsync(Guid? tenantId)
        {
            if (await _countryRepository.GetCountAsync() <= 0)
            {
                await _countryRepository.InsertManyAsync(GetCountries(tenantId: tenantId), autoSave: true);
            }

            var countries = await _countryRepository.GetListAsync();
            //foreach (var country in countries)
            //{
            //    if (!(await _stateRepository.AnyAsync(x => x.CountryId == country.Id)))
            //    {
            //        await _stateRepository.InsertManyAsync(GetColombiaStates(country.Name, tenantId, country.Id), autoSave: true);
            //    }

            //    var states = await _stateRepository.GetListAsync();

            //    foreach (var state in states)
            //    {
            //        if (!(await _cityRepository.AnyAsync(x => x.StateId == state.Id)))
            //        {
            //            await _cityRepository.InsertManyAsync(GetCities(state.Name, tenantId, country.Id, state.Id));
            //        }
            //    }
            //}
        }
    }
}