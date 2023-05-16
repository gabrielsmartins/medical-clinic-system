﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Infra.Persistence.Entity;

[Table("Medical_Appointments")]
public partial class MedicalAppointmentEntity
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("patient_id")]
    public Guid PatientId { get; set; }

    [Required]
    [Column("anamnesis")]
    [StringLength(500)]
    [Unicode(false)]
    public string Anamnesis { get; set; }

    [Column("icd")]
    [StringLength(50)]
    [Unicode(false)]
    public string Icd { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime UpdatedAt { get; set; }

    [ForeignKey("PatientId")]
    [InverseProperty("Appointments")]
    public virtual PatientEntity Patient { get; set; }
}