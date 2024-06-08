using Microsoft.EntityFrameworkCore;
using TestingASP.Models;

namespace TestingASP.DataAccessLayer;


//This will be our DB context for our application
//We only need one class that inherits from EF DbContext class in our app
//This class will be used to interact with the database
public class TestingASPContext : DbContext

{

    //We need to make our Context class aware of the model classes it needs to track for us

    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<BloodPressureRecord> BloodPressureRecords { get; set; }

    public TestingASPContext() { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //Tpc is Table Per Concrete Type
        //Which means that each class in the hierarchy will have its own table
        modelBuilder.Entity<BloodPressureRecord>().UseTpcMappingStrategy()
        .ToTable("BloodPressureRecords");

        modelBuilder.Entity<UserProfile>()
            .ToTable("UserProfiles");


    }


}
