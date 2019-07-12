using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebGYM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MGadiController : ControllerBase
    {
        // GET: MGadi
        [HttpGet]
        public ActionResult Index()
        {
            return new JsonResult("Hello");// "Your application description page.";
        } 
    }
}