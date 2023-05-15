using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class MedicalAppointmentService : IMedicalAppointmentService
    {
        private readonly MedicalAppointmentRepository _repository;

        public MedicalAppointmentService(MedicalAppointmentRepository repository)
        {
            this._repository = repository;
        }

        public MedicalAppointment Create(MedicalAppointment medicalAppointment)
        {
            return this._repository.Create(medicalAppointment);
        }

    }
}
