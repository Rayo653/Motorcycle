using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AgencyController : ControllerBase
    {
        private readonly IManagerService _service;

        public AgencyController(IManagerService service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetAgencies()
        {

            //throw new Exception("Exception");
            var agencies = _service.AgencyService.GetAllAgency(trackChanges: false);
                return Ok(agencies);
            

        }
    }
}
