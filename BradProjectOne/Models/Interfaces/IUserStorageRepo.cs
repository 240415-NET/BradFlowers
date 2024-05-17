namespace BradProjectOne.Models;

public interface IUserStorageRepo
{

    //Here I will add all the storage methods from DAL
    public void CreateUser(UserProfile user);

    public UserProfile? RetrieveUser(string userNameToFind);
}