namespace BradProjectOne.Models;

public interface IBpRecordStorageRepo
{
    public void CreateBloodPressureRecord(BloodPressureRecord newBpReading);

    public bool DeleteBloodPressureRecord(Guid userId, DateTime date);

    public List<BloodPressureRecord> ViewAllUserBpRecords(Guid userId);
}