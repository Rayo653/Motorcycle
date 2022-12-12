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


    public class PhoneController: ControllerBase
    {
        private readonly IServiceManager _service;


        public PhoneController(IServiceManager service)=>
            _service = service;


        [HttpGet]

        public IActionResult GetPhones()
        {
            try
            {
                var phones = _service.PhoneService.GetAllPhones(trackChanges: false);
                return Ok(phones);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
