namespace BradProjectOne.Models;

public interface IUserStorageRepo
{
    public void CreateUser(UserProfile user);

    public UserProfile RetrieveUser(string userNameToFind);
}