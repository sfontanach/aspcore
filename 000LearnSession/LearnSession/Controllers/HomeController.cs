using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnSession.Controllers
{
    public class HomeController : Controller
    {
        private const string SessionKey = "Key";

        public IActionResult Index()
        {
            var value = (HttpContext.Session.GetInt32(SessionKey) ?? 0) + 1;
            HttpContext.Session.SetInt32(SessionKey, value);
            return Content($"This is your {value}. visit");
        }
    }
}