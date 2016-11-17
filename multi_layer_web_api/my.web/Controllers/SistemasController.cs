using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using my.web.Models;

namespace my.web.Controllers
{
    [Route("api/[controller]")]
    public class SistemasController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Sistema> Get()
        {
            return new Sistema[] { new Sistema("My Sistema de blogs", 1) };
        }
        
    }
}
