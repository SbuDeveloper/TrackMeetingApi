using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using TrackMngmtMeeting.Infrastructure;
using TrackMngmtMeeting.Infrastructure.Extentions;
using TrackMngmtMeeting.Services.Interface;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDIServices(builder.Configuration);

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

app.MapControllers();

using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
var context = services.GetRequiredService<TrackMngmtMeetingDbContext>();
var logger = services.GetRequiredService<ILogger<Program>>();
try
{
	await context.Database.MigrateAsync();
	await TrackMngmtMeetingDbContextDataSeed.SeedAsync(context);
}
catch (Exception ex)
{
	logger.LogError(ex, "An error occured during migration");
}

app.Run();