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
    public class GarageController : ControllerBase
    {
        private readonly IManagerService _service;

        public GarageController(IManagerService service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetGarage()
        {

            //throw new Exception("Exception");
            var garage = _service.GarageService.GetAllGarages(trackChanges: false);
            return Ok(garage);


        }
    }
}
