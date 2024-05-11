using BradProjectOne.PresentationLayer;

namespace BradProjectOne.Models
{
    public class UserProfile
    {
        public Guid userId { get; set; }
        public string userName { get; set; }

        public UserProfile() { } //probably don't need this
        public UserProfile(string theUserName)
        {
            userId = Guid.NewGuid(); // Generates a new userID for the user
            userName = theUserName;
        }

    }
}