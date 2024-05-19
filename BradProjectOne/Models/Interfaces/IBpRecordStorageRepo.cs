namespace BradProjectOne.Models;

public interface IBpRecordStorageRepo
{
    public void createBloodPressureRecord(BloodPressureRecord newBpReading);

}