using Domain.Service;
using Infra.Web.Controllers.Mapper;
using Infra.Web.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;

namespace Infra.Web.Controllers
{
    [ApiController]
    [Route("api/v1/patients")]
    public class PatientController : ControllerBase
    {

        private readonly ILogger<PatientController> _logger;
        private readonly IPatientService _service;

        public PatientController(ILogger<PatientController> logger, IPatientService service)
        {
            this._logger = logger;
            this._service = service;
        }

        [HttpPost]
        [ProducesResponseType(typeof(PatientDto), (int)HttpStatusCode.Created)]
        public ActionResult<PatientDto> Create([FromBody] PatientDto patientDto)
        {
            var patient = patientDto.ToDomain();
            var createdPatient = this._service.Create(patient);
            return Created("api/vi/patients/" + createdPatient.Id, createdPatient);
        }
    }
}