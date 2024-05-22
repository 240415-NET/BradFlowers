namespace BradProjectOne.DataAccessLayer;

using BradProjectOne.Models;
using System.Text.Json;

public class BloodPressureRecordRepository : IBpRecordStorageRepo
{
    public static string filePath = "./DataAccessLayer/BPFile.json";
    public void CreateBloodPressureRecord(BloodPressureRecord bpRecord)
    {
        if (File.Exists(filePath))
        {
            string existingBpRecordsJson = File.ReadAllText(filePath); //reading json string from file
            List<BloodPressureRecord> existingBpRecordsList = JsonSerializer.Deserialize<List<BloodPressureRecord>>(existingBpRecordsJson); //deserializing json string to list
            existingBpRecordsList.Add(bpRecord); //adding user to list
            string jsonBpRecordsString = JsonSerializer.Serialize(existingBpRecordsList); //serializing list to json string
            File.WriteAllText(filePath, jsonBpRecordsString); //writing json string to a file
        }

        else if (!File.Exists(filePath))
        {
            List<BloodPressureRecord> initialBpRecordsList = new List<BloodPressureRecord>();
            initialBpRecordsList.Add(bpRecord); //adding user to list prior to serializing
            string jsonBpRecordsString = JsonSerializer.Serialize(initialBpRecordsList); //serializing list to json string
            File.WriteAllText(filePath, jsonBpRecordsString); //writing json string to a filed
        }
    }

    public bool DeleteBloodPressureRecord(Guid userId, DateTime date)
    {
        string existingBpRecordsJson = File.ReadAllText(filePath); //reading json string from file
        List<BloodPressureRecord> existingBpRecordsList = JsonSerializer.Deserialize<List<BloodPressureRecord>>(existingBpRecordsJson); //deserializing json string to list
        BloodPressureRecord bpRecordToDelete = existingBpRecordsList.Find(bpRecord => bpRecord.UserId == userId && bpRecord.Date == date); //finding user to delete
        existingBpRecordsList.Remove(bpRecordToDelete); //removing user from list
        string jsonBpRecordsString = JsonSerializer.Serialize(existingBpRecordsList); //serializing list to json string
        File.WriteAllText(filePath, jsonBpRecordsString); //writing json string to a file
        return true;
    }

    public List<BloodPressureRecord> ViewAllUserBpRecords(Guid userId)
    {
        string existingBpRecordsJson = File.ReadAllText(filePath); //reading json string from file
        List<BloodPressureRecord> existingBpRecordsList = JsonSerializer.Deserialize<List<BloodPressureRecord>>(existingBpRecordsJson); //deserializing json string to list
        List<BloodPressureRecord> userBpRecords = existingBpRecordsList.FindAll(bpRecord => bpRecord.UserId == userId); //finding all users with the same username
        return userBpRecords;
    }
}
