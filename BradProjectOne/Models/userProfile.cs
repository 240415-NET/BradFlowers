using BradProjectOne.PresentationLayer;

namespace BradProjectOne.Models
{
    public class UserProfile
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }

        public UserProfile() {}
        public UserProfile(string _userName)
        {
            UserId = Guid.NewGuid();
            UserName = _userName;
        }

        public UserProfile(Guid _userId, string _userName)
        {
            UserId = _userId;
            UserName = _userName;
        }

    }
}