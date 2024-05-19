namespace BradProjectOne.Models;

public interface IUserStorageRepo
{
    public void createUser(UserProfile user);

    public UserProfile RetrieveUser(string userNameToFind);
}