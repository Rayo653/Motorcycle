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
    public class MotorcycleController : ControllerBase
    {
        private readonly IManagerService _service;

        public MotorcycleController(IManagerService service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetMotorcycles()
        {

            //throw new Exception("Exception");
            var motrocycle = _service.MotorcycleService.GetAllMotorcycles(trackChanges: false);
            return Ok(motrocycle);


        }
    }
}
