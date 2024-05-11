namespace BradProjectOne.DataAccessLayer;
using BradProjectOne.Models;    
using System.Text.Json;


    public class UserRepository
{
    public static void createUser(UserProfile user)
    {

        string filePath = "./DataAccessLayer/UsersFile.json";
       
        if (!File.Exists(filePath))
        {
            List<UserProfile> initialUsersList = new List<UserProfile>();

            initialUsersList.Add(user); //adding user to list prior to serializing
            string jsonUsersString = JsonSerializer.Serialize(initialUsersList); //serializing list to json string
            File.WriteAllText(filePath, jsonUsersString); //writing json string to a filed
            
        }
        
        else if (File.Exists(filePath))
        {
        
            string existingUsersJson = File.ReadAllText(filePath); //reading json string from file
            List<UserProfile> existingUsersList = JsonSerializer.Deserialize<List<UserProfile>>(existingUsersJson); //deserializing json string to list
            
            existingUsersList.Add(user); //adding user to list
            string jsonUsersString = JsonSerializer.Serialize(existingUsersList); //serializing list to json string
            File.WriteAllText(filePath, jsonUsersString); //writing json string to a file
                        
        }

    }
    public static void retrieveUser()
    {

    }
}


