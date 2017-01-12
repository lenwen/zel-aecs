using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

//  // https://github.com/emqtt/emq-auth-http


namespace AecsIoT.Controllers
{
    public class EmqttController : Controller
    {
        

        [Route("emqtt/auth"), HttpPost]
        public IActionResult Auth(string clientid, string username, string password)
        {
            // ViewData["Message"] = "Your contact page.";
            Console.WriteLine("************************ auth *********************");
            Console.WriteLine("clientId: {0} | username: {1} | password: {2}", clientid, username, password);
            Console.WriteLine("************************ auth *********************");
            return Ok();
        }

        [Route("emqtt/superuser"), HttpPost]
        public IActionResult SuperUser(string clientid, string username)
        {
            // ViewData["Message"] = "Your contact page.";
            Console.WriteLine("************************ superUser *********************");
            Console.WriteLine("clientId: {0} | username: {1}", clientid, username);
            Console.WriteLine("************************ superUser *********************");
            return Ok();
            return NotFound();
            // return Ok("superUser");
            
        }

        [Route("emqtt/acl"), HttpGet]
        public IActionResult Acl(string access, string username, string clientid, string ipaddr, string topic)
        {
            // ViewData["Message"] = "Your contact page.";
            Console.WriteLine("************************ acl *********************");
            Console.WriteLine("clientId: {0} | username: {1} | ipaddr: {2} | Topic: {3} | Access: {4}", clientid, username, ipaddr,topic, access);
            // Console.WriteLine("access: {0}", string.Join(",", access));
            Console.WriteLine("************************ acl *********************");
            return Ok();
        }



        [Route("emqtt/test/{username}")]
        public IActionResult Test()
        {
            // ViewData["Message"] = "Your contact page.";

            return Ok("sdfdsfdsf");
        }
    }
}
