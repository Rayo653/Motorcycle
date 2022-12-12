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
        private readonly IManagerService _service;

        public ClientController(IManagerService service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetClients()
        {

            //throw new Exception("Exception");
            var client = _service.ClientService.GetAllClients(trackChanges: false);
            return Ok(client);


        }
    }
}
