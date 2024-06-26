using System.ComponentModel.DataAnnotations;

namespace TestingASP.Models

{
    public class UserProfile
    {
        [Key] //This is a data annotation that tells the database that this property is the primary key
        public Guid UserId { get; set; }

        public string UserName { get; set; } //Foreign key

        //Users have many BloodPressureRecords. Each of those belong to one user

        public List<BloodPressureRecord> BloodPressureRecords { get; set; } = new();
        //The above line is a shorthand way of creating a new list of BloodPressureRecords

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