using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace code.Controllers {
    [Route("/")]
    public class HelloController : Controller {
    
        [HttpGet]
        [Route("/")]
        public RedirectResult Get() {
            return Redirect("/hello");
        }

        [HttpGet]
        [Route("/hello/{name?}")]
        public string Get(string name) {
            //var greeting = String.IsNullOrWhiteSpace(name) ? "World" : name;
            var greeting = "World";
            return $"Hello, {greeting}!";
        }
    
    }
}
