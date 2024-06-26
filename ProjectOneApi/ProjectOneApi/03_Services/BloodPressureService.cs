using ProjectOneApi.Models;
using ProjectOneApi.DataAccessLayer;

namespace ProjectOneApi.Services;

public class BloodPressureRecordService : IBloodPressureRecordService
{
    private readonly IBloodPressureRecordStorageEFRepo _bloodPressureRecordStorage;

    public BloodPressureRecordService(IBloodPressureRecordStorageEFRepo efRepoFromBuilder)
    {
        _bloodPressureRecordStorage = efRepoFromBuilder;

    }

    public async Task CreateNewBloodPressureRecordInDBAsync(BloodPressureRecord newBloodPressureRecordFromController)
    {
        await _bloodPressureRecordStorage.CreateNewBloodPressureRecordInDBAsync(newBloodPressureRecordFromController);

    }
    

}
