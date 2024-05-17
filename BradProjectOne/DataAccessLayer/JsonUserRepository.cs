namespace BradProjectOne.DataAccessLayer;
using BradProjectOne.Models;
using System.Text.Json;


public class JsonUserRepository : IUserStorageRepo
{
    public static string filePath = "./DataAccessLayer/UsersFile.json";
    public void CreateUser(UserProfile user)
    {

        //string filePath = "./DataAccessLayer/UsersFile.json"; DELETE THIS LINE

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
            var existingUsersList = JsonSerializer.Deserialize<List<UserProfile>>(existingUsersJson); //deserializing json string to list
            if (existingUsersList == null)
            {
                existingUsersList = new List<UserProfile>();
            }
            existingUsersList.Add(user); //adding user to list
            string jsonUsersString = JsonSerializer.Serialize(existingUsersList); //serializing list to json string
            File.WriteAllText(filePath, jsonUsersString); //writing json string to a file

        }

    }
    public UserProfile? RetrieveUser(string userNameToFind)
    {
        
        /*need to read the string from .json file
        then need to serialize string back into a list
        then need to search the list for the user
        If exists then return the user...if it doesn't do something else
        */
        try
        {
            //string filePath = "./DataAccessLayer/UsersFile.json"; DELETE THIS LINE
            string existingUsersJson = File.ReadAllText(filePath);

            var existingUsersList = JsonSerializer.Deserialize<List<UserProfile>>(existingUsersJson); //deserializing json string to list

            return existingUsersList?.FirstOrDefault(user => user.userName == userNameToFind); //searching list for user with Lambda; works same as foreach below

            // foreach (User user in existingUsersList){
            //     if(user.userName == usernameToFind)
            //     {
            //         return user;
            //     }
            // }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return null;



    }
}


