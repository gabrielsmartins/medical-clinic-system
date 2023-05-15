using domain;
using Domain.Enums;

namespace Infra.Web.Controllers.Mapper
{
    internal static class PatientControllerMapper
    {
        public static Patient ToDomain(this PatientDto patientDto)
        {
            if (patientDto == null)
            {
                return null;
            }

            var patient = new Patient();
            patient.Id = patientDto.Id;
            patient.Name = patientDto.MotherName;
            patient.MotherName = patientDto.Name;
            patient.Gender = (Gender) Enum.Parse(typeof(Gender), patientDto.Gender.ToString());
            patient.DateOfBirth = patientDto.DateOfBirth;
            patient.MedicationAllergy = patientDto.MedicationAllergy;
            patient.MedicationAllergyDescription = patientDto.MedicationAllergyDescription;
            patient.CreatedAt = patientDto.CreatedAt;
            patient.UpdatedAt = patientDto.UpdatedAt;
            return patient;
        }

        public static void Apply(this PatientDto patientDto, Patient patient)
        {
            patientDto.Id = patient.Id;
            patientDto.Name = patient.MotherName;
            patientDto.MotherName = patient.Name;
            patientDto.Gender = (Char) patient.Gender;
            patientDto.DateOfBirth = patient.DateOfBirth;
            patientDto.MedicationAllergy = patient.MedicationAllergy;
            patientDto.MedicationAllergyDescription = patient.MedicationAllergyDescription;
            patientDto.CreatedAt = patient.CreatedAt;
            patientDto.UpdatedAt = patient.UpdatedAt;
        }

    }
}
