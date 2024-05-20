namespace BradProjectOne.Models;

public interface IBpRecordStorageRepo
{
    public void createBloodPressureRecord(BloodPressureRecord newBpReading);

    public void deleteBloodPressureRecord(Guid userId, DateTime date);
}