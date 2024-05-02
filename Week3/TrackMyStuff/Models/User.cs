using System.Security.Cryptography.X509Certificates;

namespace TrackMyStuff.Models;

public class User
{

    //Fields

    //This is an example of leveraging the get;set
    public int userId { get; private set; }

    public string userName { get; private set; }

    //Constructors

    //Default/No-Argument Constructor
    public User()
    {
    }

    public User(int _userId, string _userName)
    {
        userId = _userId;
        userName = _userName;
    }


}
