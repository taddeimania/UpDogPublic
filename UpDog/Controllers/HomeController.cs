using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace UpDog.Controllers
{

    public class MyData
    {
        
    }
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var x = new List<string> { "joel" };
            
            throw new Exception(":hankey:");
        }
    }
}