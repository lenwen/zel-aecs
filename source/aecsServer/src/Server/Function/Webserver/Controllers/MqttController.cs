using System;
using Microsoft.AspNetCore.Mvc;


using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aecs.Server.Function.Webserver.Controllers
{
    public class MqttController : Controller
    {
        [Route("mqtt/auth")]
        public IActionResult Auth()
        {
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
            Console.WriteLine("mqtt auth running");
            return Ok("mqtt auth running");
        }

        [Route("hmqtt/test/{username}")]
        public IActionResult Greet(string username)
        {
            // var greeting = new Greeting { Username = username };
            return Ok(username);
        }

    }
}
