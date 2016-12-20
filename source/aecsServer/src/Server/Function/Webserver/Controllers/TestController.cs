using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Aecs.Server.Function.Webserver.Controllers
{
 
    public class HomeController : Controller
    {
        [Route("home/index")]
        public IActionResult Index()
        {
            return Ok("Hello World from a controller");
        }

        //[Route("home/greet/{username}")]
        //public IActionResult Greet(string username)
        //{
        //    var greeting = new Greeting { Username = username };
        //    return Ok(greeting);
        //}

        [Route("home/tstview")]
        public IActionResult Tstview()
        {
            Console.WriteLine("tstview running");
            return View();
        }


    }

}
