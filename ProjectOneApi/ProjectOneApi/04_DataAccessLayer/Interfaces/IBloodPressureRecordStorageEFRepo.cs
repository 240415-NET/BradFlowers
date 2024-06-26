using ProjectOneApi.Models;

namespace ProjectOneApi.DataAccessLayer;

public interface IBloodPressureRecordStorageEFRepo
{
    public Task<BloodPressureRecord?> CreateNewBloodPressureRecordInDBAsync(BloodPressureRecord newBloodPressureRecordSentFromService);

}