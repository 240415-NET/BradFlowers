namespace BradProjectOne.Models;

public interface IBpRecordStorageRepo
{
    public void CreateBloodPressureRecord(BloodPressureRecord newBpReading);

    public bool DeleteBloodPressureRecord(Guid userId, DateTime date);

    public void ViewAllUserBpRecords(Guid userId);
}