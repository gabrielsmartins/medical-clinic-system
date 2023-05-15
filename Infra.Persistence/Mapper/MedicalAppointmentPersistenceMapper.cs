using Domain;
using Infra.Persistence.Entity;

namespace Infra.Persistence.Mapper
{
    public static class MedicalAppointmentPersistenceMapper
    {
        public static MedicalAppointmentEntity ToEntity(this MedicalAppointment medicalAppointment)
        {
            if (medicalAppointment == null)
            {
                return null;
            }

            var medicalAppointmentEntity = new MedicalAppointmentEntity();
            medicalAppointmentEntity.Id = medicalAppointment.Id;
            medicalAppointmentEntity.PatientId = medicalAppointment.Patient.Id;
            medicalAppointmentEntity.Anamnesis = medicalAppointment.Anamnesis;
            medicalAppointmentEntity.Icd = medicalAppointment.Icd;
            medicalAppointmentEntity.CreatedAt = medicalAppointment.CreatedAt;
            medicalAppointmentEntity.UpdatedAt = medicalAppointment.UpdatedAt;
            medicalAppointmentEntity.Patient = medicalAppointment.Patient.ToEntity();
            return medicalAppointmentEntity;
        }

        public static void Apply(this MedicalAppointment medicalAppointment, MedicalAppointmentEntity medicalAppointmentEntity)
        {
            if (medicalAppointmentEntity == null)
            {
                return;
            }

            medicalAppointment = new MedicalAppointment();
            medicalAppointment.Id = medicalAppointmentEntity.Id;
            medicalAppointment.Anamnesis = medicalAppointmentEntity.Anamnesis;
            medicalAppointment.Icd = medicalAppointmentEntity.Icd;
            medicalAppointment.CreatedAt = medicalAppointmentEntity.CreatedAt;
            medicalAppointment.UpdatedAt = medicalAppointmentEntity.UpdatedAt;
            medicalAppointment.Patient.Apply(medicalAppointmentEntity.Patient);
        }
    }
}
