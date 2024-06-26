using ProjectOneApi.Models;

namespace ProjectOneApi.Services;

public interface IBloodPressureRecordService
{
    public Task CreateNewBloodPressureRecordInDBAsync(BloodPressureRecord newBloodPressureRecordFromController);
}