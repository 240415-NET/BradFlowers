using ProjectOneApi.Services;
using ProjectOneApi.DataAccessLayer;
using Microsoft.EntityFrameworkCore;


//This program.cs is very different from what we've seen
//It runs almost as a script from top to bottom where we add our services to our appbuilder and then run the app
//and then we build the app.  After built we can toggle different options for it
//All of this is done when we dotnet run our webapi project

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builders we are adding for User
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserStorageEFRepo, UserStorageEFRepo>(); //This adds the UserStorageEFRepo to the services

//builders we are adding for BloodPressure
builder.Services.AddScoped<IBloodPressureRecordService, IBloodPressureRecordService>();
builder.Services.AddScoped<IBloodPressureRecordStorageEFRepo, BloodPressureStorageEFRepo>();

string connectionString = File.ReadAllText(@"C:\ReposForBootcamp\ConnStringEFASP.txt");
builder.Services.AddDbContext<ProjectOneApiContext>(options => options.UseSqlServer(connectionString));//This adds the DBContext to the services

//AddControllers is pre-built, we just moved to the bottom of the list
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Editin our apps CORS policy to allow us to use DELETE and other desctruvtive methods
app.UseCors(policy => policy.AllowAnyMethod());

app.UseAuthorization();

app.MapControllers();

app.Run();
