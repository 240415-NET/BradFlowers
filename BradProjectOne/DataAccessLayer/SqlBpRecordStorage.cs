using BradProjectOne.Models;
using System.Data.SqlClient;


namespace BradProjectOne.DataAccessLayer;

public class SqlBpRecordStorage : IBpRecordStorageRepo
{

    public static string connectionString = File.ReadAllText(@"C:\ReposForBootcamp\ConnString.txt");

    public void CreateBloodPressureRecord(BloodPressureRecord bpRecord)
    {
        SqlConnection connection = new SqlConnection(connectionString);  //creates a new connection to the database
        connection.Open();
        string cmdText = @"INSERT INTO dbo.BloodPressureRecord (ReadingId, UserId, UserName, Systolic, Diastolic, Pulse, ReadingDate) 
                            VALUES (@ReadingId, @UserId, @UserName, @Systolic, @Diastolic, @Pulse, @ReadingDate);";

        using (SqlCommand cmd = new SqlCommand(cmdText, connection)) //creates a new command(can call it anything- I used cmd here)
        {
            cmd.Parameters.AddWithValue("@ReadingId", bpRecord.ReadingId); //adds the user id to the command, same with all the ones beloww
            cmd.Parameters.AddWithValue("@UserId", bpRecord.UserId);
            cmd.Parameters.AddWithValue("@UserName", bpRecord.UserName);
            cmd.Parameters.AddWithValue("@Systolic", bpRecord.Systolic);
            cmd.Parameters.AddWithValue("@Diastolic", bpRecord.Diastolic);
            cmd.Parameters.AddWithValue("@Pulse", bpRecord.Pulse);
            cmd.Parameters.AddWithValue("@ReadingDate", bpRecord.Date);
            cmd.ExecuteNonQuery(); //executes the command to INSERT new row to the dbo.UserProfile table
            connection.Close(); //closes the connection
        }
    }

    public void DeleteBloodPressureRecord(Guid userId, DateTime date) //Note that the method names must match those on the interface
    {
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        string cmdText = @"DELETE FROM dbo.BloodPressureRecord 
                            WHERE UserId = @UserId AND ReadingDate = @ReadingDate;";

        using (SqlCommand cmd = new SqlCommand(cmdText, connection))
        {
            cmd.Parameters.AddWithValue("@UserId", userId); //adds the user id to the command
            cmd.Parameters.AddWithValue("@ReadingDate", date);
            cmd.ExecuteNonQuery();
            connection.Close();

        }
    }

    public void ViewAllUserBpRecords(UserProfile userName)
    {
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        string cmdText = @"SELECT ReadingId, UserId, UserName, Systolic, Diastolic, Pulse, ReadingDate
                            FROM dbo.BloodPressureRecord
                            WHERE UserName = @UserName;";

        using (SqlCommand cmd = new SqlCommand(cmdText, connection))
        {
            cmd.Parameters.AddWithValue("@UserName", userName);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"ReadingId: {reader["ReadingId"]}, UserId: {reader["UserId"]}, UserName: {reader["UserName"]}, Systolic: {reader["Systolic"]}, Diastolic: {reader["Diastolic"]}, Pulse: {reader["Pulse"]}, ReadingDate: {reader["ReadingDate"]}");

                }
            }
        }
        connection.Close();
    }
}