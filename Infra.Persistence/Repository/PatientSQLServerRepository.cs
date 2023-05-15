using Domain;
using Domain.Repository;
using Infra.Persistence.Context;
using Infra.Persistence.Mapper;

namespace Infra.Persistence.Repository
{
    public class PatientSQLServerRepository : PatientRepository
    {
        private readonly MedicalClinicSystemContext _context;

        public PatientSQLServerRepository(MedicalClinicSystemContext context)
        {
            this._context = context;
        }

        public Patient Create(Patient patient)
        {
            var patientEntity = patient.ToEntity();
            this._context.Patients.Add(patientEntity);
            this._context.SaveChanges();
            patient.Id = patientEntity.Id;
            return patient;
        }

    }
}
