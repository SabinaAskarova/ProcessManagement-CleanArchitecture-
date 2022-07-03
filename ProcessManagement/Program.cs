using ProcessManagementInfrastucture;
//using MediatR;
using ProcessManagementApplication.Users.Commands;
using MediatR;
using ProcessManagementAPI.Controllers;
using System.Reflection;
using ProcessManagementApplication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfraStructure();
builder.Services.AddApplication();
//builder.Services.AddInfrastructure();
builder.Services.AddControllers();
//builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
//var assembly = AppDomain.CurrentDomain.Load("Data");
//builder.Services.AddMediatR(assembly);
//builder.Services.AddMediatR(typeof(Program));

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

