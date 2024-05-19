using BradProjectOne.Models;
using BradProjectOne.DataAccessLayer;


namespace BradProjectOne.ControllersLayer;

public class BloodPressureController
{
    private static IBpRecordStorageRepo _bloodPressureRecord = new BloodPressureRecordRepository();

    public BloodPressureController(IBpRecordStorageRepo bloodPressureRecordRepository)
    {
        _bloodPressureRecord = bloodPressureRecordRepository;
    }

    public static void CreateBloodPressureRecord(Guid userId, string userName, Guid readingId, int systolic, int diastolic, int pulse, DateTime date)
    {
        BloodPressureRecord newBpReading = new BloodPressureRecord(userId, userName, readingId, systolic, diastolic, pulse, date); 
        _bloodPressureRecord.createBloodPressureRecord(newBpReading);
    }

}

