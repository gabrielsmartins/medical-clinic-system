using Domain.Repository;
using Domain.Service;
using Domain.UnitTest.Support;
using Moq;
using Xunit;

namespace Domain.UnitTest.Service
{
    public class PatientServiceTest
    {

        private readonly PatientService _service;
        private readonly Moq.Mock<PatientRepository> _repositoryMock;

        public PatientServiceTest()
        {
            this._repositoryMock = new Moq.Mock<PatientRepository>();
            var repository = _repositoryMock.Object;
            this._service = new PatientService(repository);
        }

  
        [Fact]
        public void givenPatientWhenSaveThenReturnSavedPatient()
        {
            this._repositoryMock.Setup(x => x.Create(It.IsAny<Patient>()))
                                .Returns<Patient>(p => p);

            var patient = PatientSupport.defaultPatient().Build();

            var createdPatient = this._service.Create(patient);
            Assert.NotNull(createdPatient);
        }

    }
}
