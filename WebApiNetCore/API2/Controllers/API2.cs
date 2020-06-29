using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class API2 : ControllerBase
    {
        private readonly ILogger<API2> _logger;

        public API2(ILogger<API2> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[action]")]
        public string showmethecode()
        {
            return "https://github.com/Brunohvc/desafioWebAPI";
        }

        [HttpGet]
        [Route("[action]")]
        public string calculajuros([FromQuery] decimal valorinicial, [FromQuery] int meses)
        {
            var response = SendRequest("https://localhost:44308/API1/taxaJuros");
            decimal juros = Decimal.Parse(response);
            decimal parte1 = (decimal)Math.Pow(Convert.ToDouble((1 + juros)), meses);
            decimal valorFinal = valorinicial * parte1;

            return valorFinal.ToString("0.00");
        }

        private static string SendRequest(string path)
        {
            var webClient = new WebClient();
            webClient.Headers["Content-Type"] = "application/json; charset=utf-8";
            return webClient.DownloadString(path);
        }
    }
}
