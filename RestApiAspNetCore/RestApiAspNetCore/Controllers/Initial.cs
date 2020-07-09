using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestApiAspNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Initial : ControllerBase
    {
        [HttpGet("start")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok("Started");
        }
    }
}
