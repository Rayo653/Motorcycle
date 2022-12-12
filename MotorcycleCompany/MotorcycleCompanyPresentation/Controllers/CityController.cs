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
    public class CityController: ControllerBase
    {
        private readonly IServiceManager _service;

        public CityController(IServiceManager service) =>
            _service = service;

        [HttpGet]

        public IActionResult GetCities()
        {
            try
            {

                var cities = _service.CityService.GetAllCities(trackChanges: false);
                return Ok(cities);
            }catch
            {
                return StatusCode(500, "Internal Server Error");

            }
        }

    }
}
