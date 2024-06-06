namespace TestingASP.Models
{
    public class UserProfile
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }

        public UserProfile() { }
        public UserProfile(string userName)
        {
            UserId = Guid.NewGuid();
            UserName = userName;
        }

        public UserProfile(Guid userId, string userName)
        {
            UserId = userId;
            UserName = userName;
        }

    }
}