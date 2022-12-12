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
    public class PhoneController : ControllerBase
    {
        private readonly IManagerService _service;

        public PhoneController(IManagerService service) =>
            _service = service;


        [HttpGet]
        public IActionResult GetPhone()
        {
            //throw new Exception("Exception");
            var phones = _service.PhoneService.GetAllPhones(trackChanges: false);
                return Ok(phones);

        }
    }
}
