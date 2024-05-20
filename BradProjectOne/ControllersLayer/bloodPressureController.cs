using BradProjectOne.Models;
using BradProjectOne.DataAccessLayer;


namespace BradProjectOne.ControllersLayer;

public class BloodPressureController
{
    private static IBpRecordStorageRepo _bloodPressureRecord = new BloodPressureRecordRepository();
    
    public static void CreateBloodPressureRecord(UserProfile user, Guid readingId, int systolic, int diastolic, int pulse, DateTime date)
    {
        BloodPressureRecord newBpReading = new BloodPressureRecord(user.UserId, user.UserName, readingId, systolic, diastolic, pulse, date); 
        _bloodPressureRecord.createBloodPressureRecord(newBpReading);
    }

    public static void DeleteBloodPressureRecord(Guid userId, DateTime date)
    {
        _bloodPressureRecord.deleteBloodPressureRecord(userId, date);
    }

}

