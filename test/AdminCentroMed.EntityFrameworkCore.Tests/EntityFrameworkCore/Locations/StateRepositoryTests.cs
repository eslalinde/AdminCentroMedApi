using System;
using System.Threading.Tasks;
using AdminCentroMed.Locations;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace AdminCentroMed.EntityFrameworkCore.Locations;

public class StateRepositoryTests : AdminCentroMedEntityFrameworkCoreTestBase
{
    private readonly IStateRepository _stateRepository;

    public StateRepositoryTests()
    {
        _stateRepository = GetRequiredService<IStateRepository>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        await WithUnitOfWorkAsync(async () =>
        {
            // Arrange

            // Act

            //Assert
        });
    }
    */
}
