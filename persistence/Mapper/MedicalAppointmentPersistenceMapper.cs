using Domain;
using Persistence.Entity;
using Persistence.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
