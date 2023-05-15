using domain;
using Domain.Repository;
using Persistence.Context;
using Persistence.Entity;
using Persistence.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
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
