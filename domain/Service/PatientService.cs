using Domain.Repository;

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
