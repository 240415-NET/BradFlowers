namespace BradProjectOne.Models;

public interface IBpRecordStorageRepo
{
    public void CreateBloodPressureRecord(BloodPressureRecord newBpReading);

    public void DeleteBloodPressureRecord(Guid userId, DateTime date);

    public void ViewAllUserBpRecords(Guid userId);
}