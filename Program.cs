using BackendNET.Models;
using Microsoft.EntityFrameworkCore;

//Boilerplate de microsoft

var builder = WebApplication.CreateBuilder(args);

//Cargo la config
var conn = builder.Configuration.GetConnectionString("DefaultConnection");

// Añado servicios

//Contexto de la DB
builder.Services.AddDbContext<CustomersContext>(opt => opt.UseNpgsql(conn));
builder.Services.AddControllers();
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
