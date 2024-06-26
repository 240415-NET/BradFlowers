using Microsoft.EntityFrameworkCore;
using ProjectOneApi.Models;

namespace ProjectOneApi.DataAccessLayer;


//This class is going to be our DB context class for our application.
//We only need one class that inherits from the EF Core DBContext class in our app.
//This class is what will handle our EF Core DB communication for us--assumes just one DB and one DB only
public class ProjectOneApiContext : DbContext
{
    //We need to make our Context class aware of the model classes it needs to track for us.
    //We do this by creating DbSets for our model classes. MAKE SURE YOU HAVE A GET; SET;

    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<BloodPressureRecord> BloodPressureRecords { get; set; }

    public ProjectOneApiContext() { }

    public ProjectOneApiContext(DbContextOptions<ProjectOneApiContext> options) : base(options) { }

    //In order to tweak EF Cores default behavior/assumptions of what we want in our DB
    //Whether it is with regards to things like table structure, relationships, pk/fk, how it handles
    //inheritance, etc. we need to explicitly override a method that comes from that DBContext base class
    //called OnModelCreating()

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //Here we override EF Core's default behavior for our UserProfiles table
        //in our database, by forcing the use of Table-per-concrete mapping.  This will create
        //a separate table with all columns for objects that are part of an inheritance hierarchy
        //We will add this call for earch of our models in the hierarchy
        modelBuilder.Entity<BloodPressureRecord>().UseTpcMappingStrategy()
            .ToTable("BloodPressureRecords");

        modelBuilder.Entity<UserProfile>()
            .ToTable("UserProfiles");

    //This line of code is going to force EF Core to use the SQL_Latin1_General_CP1_CI_AS collation, which is case sensitive
    modelBuilder.UseCollation("SQL_Latin1_General_CP1_CS_AS");
        
    }
}
