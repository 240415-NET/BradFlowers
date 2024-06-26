using TestingASP.Services;
using TestingASP.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//Default servies from Template are AddControllers(), AddEndpointsApiExplorer(), AddSwaggerGen()

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//here are the dependencies we are going to register or choose to bring in
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserStorageEFRepo, UserStorageEFRepo>(); //This adds the EFRepo to the UserService asks for


//Below we added the DbContext to the services(that inherits from EF Core DbContext) to be used by the EFRepo

string connectionString = File.ReadAllText(@"C:\ReposForBootcamp\ConnStringEFASP.txt"); //not necessarily needed and could just throw the path in the UseSqlServer method

builder.Services.AddDbContext<TestingASPContext>(options => options.UseSqlServer(connectionString));


//This came in by default from the template, we just moved it after our dependencies
builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
