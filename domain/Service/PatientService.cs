using domain;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class PatientService : IPatientService
    {
        private readonly PatientRepository _repository;

        public PatientService(PatientRepository repository)
        {
            this._repository = repository;
        }

        public Patient Create(Patient patient)
        {
            return this._repository.Create(patient);
        }

    }
}
