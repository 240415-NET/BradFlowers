namespace BradProjectOne.DataAccessLayer;

using BradProjectOne.Models;
using System.Data.SqlClient;

public class SqlUserStorage : IUserStorageRepo
{

    public static string connectionString = File.ReadAllText(@"C:\ReposForBootcamp\ConnString.txt");

    public void CreateUser(UserProfile user) //method to create a user
    {
        SqlConnection connection = new SqlConnection(connectionString);  //creates a new connection to the database
        connection.Open();
        string cmdText = @"INSERT INTO dbo.UserProfile (UserId, UserName) 
                            VALUES (@UserId, @UserName);";
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
        UserProfile foundUser = new UserProfile();
        using SqlConnection connection = new SqlConnection(connectionString);

        try
        {
            connection.Open(); //opens the connection

            //@ at the beginning is a parameter that can be used to pass in a value
            //selects all columns from dbo.UserProfile in the FROM portion
            //WHERE clause filters the results to only include rows where the UserName is equal to the parameter
            string cmdText = @"SELECT UserId, UserName
                                FROM dbo.UserProfile 
                                WHERE UserName=@userToFind ";
            using SqlCommand cmd = new SqlCommand(cmdText, connection); //creates a new command(can call it anything- I used cmd here)
            cmd.Parameters.AddWithValue("@userToFind", userNameToFind); //adds the user name to the command
            using SqlDataReader reader = cmd.ExecuteReader(); //creates a new reader to read the results of the command
            while (reader.Read()) //while there are rows to read
            {
                foundUser.UserId = reader.GetGuid(0); //gets the user id from the first column
                foundUser.UserName = reader.GetString(1); //gets the user name from the second column
            }
            connection.Close(); //closes the connection

            if (foundUser.UserId == Guid.Empty)
            {
                return null;
            }
            //Otherwise we return the found filled out user object
            return foundUser;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            connection.Close();
        }
        return null; //if the user is not found, return null
    }
}