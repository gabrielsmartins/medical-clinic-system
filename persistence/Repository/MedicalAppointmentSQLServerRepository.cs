using Domain;
using Domain.Repository;
using Infra.Persistence.Mapper;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Persistence.Repository
{
    public class MedicalAppointmentSQLServerRepository : MedicalAppointmentRepository
    {
        private readonly MedicalClinicSystemContext _context;

        public MedicalAppointment Create(MedicalAppointment medicalAppointment)
        {
            var medicalAppointmentEntity =  medicalAppointment.ToEntity();
            this._context.MedicalAppointments.Add(medicalAppointmentEntity);
            this._context.SaveChanges();
            medicalAppointment.Id = medicalAppointmentEntity.Id;
            return medicalAppointment;
        }

    }
}
