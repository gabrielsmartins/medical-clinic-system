
using domain;
using Persistence.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Mapper
{
    internal static class PatientPersistenceMapper
    {
        internal static PatientEntity ToEntity(this Patient patient)
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
            patientEntity.MedicationAllergy = patientEntity.MedicationAllergy;
            patientEntity.MedicationAllergyDescription = patient.MedicationAllergyDescription;
            patientEntity.CreatedAt = patient.CreatedAt;
            patientEntity.UpdatedAt = patient.UpdatedAt;
            return patientEntity;
        }

        internal static void Apply(this Patient patient, PatientEntity patientEntity)
        {
            if (patient == null)
            {
                return;
            }

            patient.Id = patientEntity.Id;
            patient.Name = patientEntity.Name;
            patient.MotherName = patientEntity.MotherName;
            patient.DateOfBirth = patientEntity.DateOfBirth;
            patient.Gender = patientEntity.Gender;
            patient.MedicationAllergy = patientEntity.MedicationAllergy;
            patient.MedicationAllergyDescription = patientEntity.MedicationAllergyDescription;
            patient.CreatedAt = patientEntity.CreatedAt;
            patient.UpdatedAt = patientEntity.UpdatedAt;
        }
    }
}
