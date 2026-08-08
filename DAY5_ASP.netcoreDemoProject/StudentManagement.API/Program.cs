using StudentManagementAPI.BusinessLayer;
using StudentManagementAPI.RepositoryLayer;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();


builder.Services.AddScoped<IStudentRL, StudentRL>();

builder.Services.AddScoped<IStudentBL, StudentBL>();



var app = builder.Build();



app.MapControllers();


app.Run();