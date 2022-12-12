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
    public class CityController : ControllerBase
    {
        private readonly IManagerService _service;

        public CityController(IManagerService service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetCities()
        {

            //throw new Exception("Exception");
            var citys = _service.CityService.GetAllCities(trackChanges: false);
            return Ok(citys);


        }
    }
}
