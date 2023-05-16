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
builder.Services.AddTransient<IPatientService, PatientService>();
builder.Services.AddTransient<PatientRepository, PatientSQLServerRepository>();
builder.Services.AddTransient<MedicalAppointmentRepository, MedicalAppointmentSQLServerRepository>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddDbContext<MedicalClinicSystemContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("MedicalClinicDb")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
