using Domain.Repository;
using Domain.Service;
using Domain.UnitTest.Support;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Domain.UnitTest.Service
{
    public class MedicalAppointmentServiceTest
    {
        private readonly MedicalAppointmentService _service;
        private readonly Moq.Mock<MedicalAppointmentRepository> _repositoryMock;

        public MedicalAppointmentServiceTest()
        {
            this._repositoryMock = new Moq.Mock<MedicalAppointmentRepository>();
            var repository = _repositoryMock.Object;
            this._service = new MedicalAppointmentService(repository);
        }

        [Fact]
        public void givenMedicalAppointmentWhenCreateThenReturnCreatedMedicalAppointment()
        {
            this._repositoryMock.Setup(x => x.Create(It.IsAny<MedicalAppointment>()))
                                .Returns<MedicalAppointment>(p => p);

            var medicalAppointment = MedicalAppointmentSupport.defaultMedicalAppointment().Build();

            var createdMedicalAppointment = this._service.Create(medicalAppointment);
            Assert.NotNull(createdMedicalAppointment);
        }
    }
}
