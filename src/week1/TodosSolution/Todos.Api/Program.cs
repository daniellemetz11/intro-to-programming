
using Marten;
using Todos.Api.Todos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(pol =>
{
    pol.AddDefaultPolicy(c =>
    {
        c.AllowAnyHeader();
        c.AllowAnyMethod();
        c.AllowAnyOrigin();
    });
});
// Add services to the container.
builder.Services.AddAuthorization();

var connectionString = builder.Configuration.GetConnectionString("todos") ?? throw new Exception("can't start the api without a connection string");

builder.Services.AddMarten(builder =>
{
    builder.Connection(connectionString);
});

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//above this line is configuration for the services inside our application
var app = builder.Build();
//below this line is configuration for how http requests and responses are handled

app.UseCors();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapTodos();

app.Run(); //kind of an infinite for loop looking for an HTTP request to handle and send a response. multithreaded so can handle multiple requests. This service eventually assigned to a computer/cloud somewhere and just keeps listening

Console.WriteLine("Done running the application");




//making program public so it can be used with alba to let unit tests start the apis

public partial class Program { }