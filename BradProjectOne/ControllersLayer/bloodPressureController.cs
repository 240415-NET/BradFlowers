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

    public static void CreateBloodPressureRecord(int systolic, int diastolic, int pulse, DateTime date)
    {
        BloodPressureRecord newBpReading = new BloodPressureRecord(systolic, diastolic, pulse, date); 
        _bloodPressureRecord.createBloodPressureRecord(newBpReading);
    }

}

