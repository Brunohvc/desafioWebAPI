using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class API1 : ControllerBase
    {
        private readonly ILogger<API1> _logger;

        public API1(ILogger<API1> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[action]")]
        public string taxaJuros()
        {
            return "0,01";
        }
    }
}
