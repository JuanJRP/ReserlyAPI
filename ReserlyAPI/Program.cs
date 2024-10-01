using Microsoft.EntityFrameworkCore;
using ReserlyAPI.Context;
using ReserlyAPI.Repositories;
using ReserlyAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Connection String
var connectionString = builder.Configuration.GetConnectionString("Connection");
// Register connection service
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddControllers();

builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
builder.Services.AddScoped<IReservationService, ReservationService>();

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
