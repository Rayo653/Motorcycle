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
    public class MotorcycleController: ControllerBase
    {
        private readonly IServiceManager _service;

        public MotorcycleController(IServiceManager service)=>
            _service = service;
        
        [HttpGet]

        public IActionResult GetMotorcycles()
        {
            try
            {

                var motorcycles = _service.MotorcycleService.GetAllMotorcycles(trackChanges: false);
                return Ok(motorcycles);

            }
            catch
            {
                return StatusCode(500, "Internal Server Error");
            }

        }
    }
}
