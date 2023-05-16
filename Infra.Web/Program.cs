using Domain.Repository;
using Domain.Service;
using Infra.Persistence.Context;
using Infra.Persistence.Repository;
using Infra.Web;
using Infra.Web.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
                });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<DbContext, MedicalClinicSystemContext>();
builder.Services.AddTransient<IPatientService, PatientService>();
//builder.Services.AddTransient<PatientRepository, PatientSQLServerRepository>();
//builder.Services.AddTransient<MedicalAppointmentRepository, MedicalAppointmentSQLServerRepository>();
builder.Services.AddHttpContextAccessor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

/*using var scope = app.Services.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<MedicalClinicSystemContext>();
var env = app.Services.GetService<IWebHostEnvironment>();
await context.Database.MigrateAsync();*/

//app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
