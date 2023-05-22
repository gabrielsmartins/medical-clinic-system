
using Domain;
using Domain.Enums;
using Infra.Persistence.Entity;
using System;

namespace Infra.Persistence.Mapper
{
    public static class PatientPersistenceMapper
    {
        public static PatientEntity ToEntity(this Patient patient)
        {
            if (patient == null)
            {
                return null;
            }

            var patientEntity = new PatientEntity();
            patientEntity.Id = patient.Id;
            patientEntity.Name = patient.Name;
            patientEntity.MotherName = patient.MotherName;
            patientEntity.DateOfBirth = patient.DateOfBirth;
            patientEntity.Gender = (Char) patient.Gender;
            patientEntity.MedicationAllergy = patient.MedicationAllergy;
            patientEntity.MedicationAllergyDescription = patient.MedicationAllergyDescription;
            patientEntity.CreatedAt = patient.CreatedAt;
            patientEntity.UpdatedAt = patient.UpdatedAt;
            return patientEntity;
        }

        public static void Apply(this Patient patient, PatientEntity patientEntity)
        {
            if (patient == null)
            {
                return;
            }

            patient.Id = patientEntity.Id;
            patient.Name = patientEntity.Name;
            patient.MotherName = patientEntity.MotherName;
            patient.DateOfBirth = patientEntity.DateOfBirth;
            patient.Gender = (Gender) Enum.ToObject(typeof(Gender), patientEntity.Gender);
            patient.MedicationAllergy = patientEntity.MedicationAllergy;
            patient.MedicationAllergyDescription = patientEntity.MedicationAllergyDescription;
            patient.CreatedAt = patientEntity.CreatedAt;
            patient.UpdatedAt = patientEntity.UpdatedAt;
        }
    }
}
