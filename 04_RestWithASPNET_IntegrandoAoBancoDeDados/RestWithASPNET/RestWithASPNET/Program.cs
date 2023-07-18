using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RestWithASPNET.Model.Context;
using RestWithASPNET.Service;
using RestWithASPNET.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container...

builder.Services.AddControllers();

var connection = builder.Configuration["MySQLConnection:MySQLConnectionString"];

builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql(connection, ServerVersion.Parse("7.0")));

//Dependency Injection
builder.Services.AddScoped<IPersonService, PersonServiceImplementation>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
