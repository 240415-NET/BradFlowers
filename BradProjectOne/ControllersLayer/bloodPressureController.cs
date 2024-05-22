namespace BradProjectOne.ControllersLayer;

using BradProjectOne.Models;
using BradProjectOne.DataAccessLayer;

public class BloodPressureController
{
    private static IBpRecordStorageRepo _bloodPressureRecord = new SqlBpRecordStorage();

    public static void CreateBloodPressureRecord(UserProfile user, Guid readingId, int systolic, int diastolic, int pulse, DateTime date)
    {
        BloodPressureRecord newBpReading = new BloodPressureRecord(user.UserId, user.UserName, readingId, systolic, diastolic, pulse, date);
        _bloodPressureRecord.CreateBloodPressureRecord(newBpReading);
    }

    public static bool DeleteBloodPressureRecord(Guid userId, DateTime date)
    {
        return _bloodPressureRecord.DeleteBloodPressureRecord(userId, date);
    }

    public static List<BloodPressureRecord> ViewAllUserBpRecords(Guid userId)

    {
        return _bloodPressureRecord.ViewAllUserBpRecords(userId);
    }
}