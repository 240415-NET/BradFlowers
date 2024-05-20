using BradProjectOne.Models;
using System.Data.SqlClient;


namespace BradProjectOne.DataAccessLayer;

public class SqlUserStorage : IUserStorageRepo
{

    public static string connectionString = File.ReadAllText(@"C:\ReposForBootcamp\ConnString.txt");

    public void CreateUser(UserProfile user)
    {
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        string cmdText = "@INSERT INTO dbo.UserProfile (UserId, UserName) VALUES (@UserId, @UserName)";
         
        using (SqlCommand cmd = new SqlCommand(cmdText, connection)) //creates a new command(can call it anything- I used cmd here)
        {
            cmd.Parameters.AddWithValue("@UserId", user.UserId); //adds the user id to the command
            cmd.Parameters.AddWithValue("@UserName", user.UserName); // adds the user name to the command
            cmd.ExecuteNonQuery(); //executes the command to INSERT new row to the dbo.UserProfile table
            connection.Close(); //closes the connection
        }
        

    }

    public UserProfile RetrieveUser(string userNameToFind)
    {
        throw new NotImplementedException();
    }
}