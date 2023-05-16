﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using Castle.Core.Configuration;
using Infra.Persistence.Context.Converter;
using Infra.Persistence.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infra.Persistence.Context;

public partial class MedicalClinicSystemContext : DbContext
{
    public MedicalClinicSystemContext()
    {
    }

    public MedicalClinicSystemContext(DbContextOptions<MedicalClinicSystemContext> options) : base(options)
    {
    }

    public virtual DbSet<MedicalAppointmentEntity> MedicalAppointments { get; set; }

    public virtual DbSet<PatientEntity> Patients { get; set; }

// protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(builder.GetConnectionString("MedicalClinicDb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MedicalAppointmentEntity>(entity =>
        {
            entity.HasOne(d => d.Patient)
                  .WithMany(p => p.Appointments)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_Medical_Appointment_Patients");
        });

        modelBuilder.Entity<PatientEntity>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Gender).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder builder)
    {
        builder.Properties<DateOnly>()
        .HaveConversion<DateOnlyConverter>()
        .HaveColumnType("date");
        base.ConfigureConventions(builder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}