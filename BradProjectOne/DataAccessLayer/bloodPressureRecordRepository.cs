namespace BradProjectOne.DataAccessLayer;
using BradProjectOne.Models;
using System.Text.Json;


public class BloodPressureRecordRepository : IBpRecordStorageRepo
{
    public static string filePath = "./DataAccessLayer/BPFile.json";
    public void createBloodPressureRecord(BloodPressureRecord bpRecord)
    {
        if (File.Exists(filePath))
        {string existingBpRecordsJson = File.ReadAllText(filePath); //reading json string from file
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


    //         List<BloodPressureRecord> newBpEntry = new List<BloodPressureRecord>();

    //         newBpEntry.Add(bpRecord); //adding user to list prior to serializing
    //         string jsonBpRecordsString = JsonSerializer.Serialize(newBpEntry); //serializing list to json string
    //         File.WriteAllText(filePath, jsonBpRecordsString); //writing json string to a filed

    // }
    }
}

        