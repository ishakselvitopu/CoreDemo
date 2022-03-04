using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class ErrorPageContorller : Controller
    {
        public IActionResult Error1(int code)
        {

            return View();
        }
    }
}
