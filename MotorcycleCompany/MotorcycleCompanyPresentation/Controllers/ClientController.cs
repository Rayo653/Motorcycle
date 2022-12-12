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
    public class ClientController : ControllerBase
    {

        private readonly IServiceManager _service;


        public ClientController(IServiceManager service)
            => _service = service;

        [HttpGet]

        public IActionResult GetClients()
        {


            try
            {
                var clients = _service.ClientService.GetAllClients(trackChanges: false);
                return Ok(clients);

            }
            catch
            {
                   return StatusCode(500, "Internal Server Error");

            }
    }
    }

}
