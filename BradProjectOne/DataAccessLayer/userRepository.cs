namespace BradProjectOne.DataAccessLayer;
using BradProjectOne.Models;    
using System.Text.Json;


    public class UserRepository
{
    public static void createUser(UserProfile user)
    {

        string filePath = "UsersFile.json";
        List<UserProfile> usersList = new List<UserProfile>();



        if (!File.Exists(filePath))
        {
            usersList.Add(user); //adding user to list prior to serializing
            string jsonUsersString = JsonSerializer.Serialize(usersList); //serializing list to json string
            File.WriteAllText(filePath, jsonUsersString); //writing json string to a filed
            
        }
        else if (File.Exists(filePath))
        {
            
        }

    }
    public static void retrieveUser()
    {

    }
}


