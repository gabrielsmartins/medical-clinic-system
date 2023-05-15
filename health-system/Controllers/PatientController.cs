using domain;
using Domain.Service;
using Infra.Web.Controllers.Mapper;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace health_system.Controllers
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
        [ProducesResponseType(typeof(PatientDto), (int) HttpStatusCode.Created)]
        public ActionResult<PatientDto> Create([FromBody] PatientDto patientDto)
        {
            var patient = patientDto.ToDomain();
            var createdPatient = this._service.Create(patient);
            var uri = new Uri(Url.Link("api/v1/patients", new { id = createdPatient.Id }));
            return Created(uri, createdPatient);
        }
    }
}