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
    public class RentController : ControllerBase
    {
        private readonly IManagerService _service;

        public RentController(IManagerService service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetRent()
        {

            //throw new Exception("Exception");
            var rent = _service.RentService.GetAllRents(trackChanges: false);
            return Ok(rent);


        }
    }
}
