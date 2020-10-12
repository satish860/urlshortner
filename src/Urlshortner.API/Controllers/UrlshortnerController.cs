using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Urlshortner.core;

namespace Urlshortner.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UrlshortnerController : ControllerBase
    {
        public IActionResult CreateShortUrl(string url)
        {
            return Ok("");
        }
    }
}
