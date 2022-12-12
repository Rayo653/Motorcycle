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
    public class AgencyController: ControllerBase
    {
        private readonly IServiceManager _service;

        public AgencyController(IServiceManager service) =>
            _service = service;

        [HttpGet]

        public IActionResult GetAgencies()
        {
            try
            {
                var agencies = _service.AgencyService.GetAllAgencies(trackChanges: false);
                return Ok(agencies);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
