using Microsoft.EntityFrameworkCore;
using WebApiAutores2;
using WebApiAutores2.Modelos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var configuration = builder.Configuration;

builder.Services.AddControllers();

builder.Services.AddDbContext<AplicattionDbContext>((options) => options.UseSqlServer(connectionString: configuration.GetConnectionString("defaultConnection")));


//Action<string, string, int> Action = (op, sd, d) => Console.WriteLine(""); 


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
