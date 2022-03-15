using BussinessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class MessageController : Controller
    {
        Message2Manager message2Manager = new Message2Manager(new EfMessage2Repository());
        [AllowAnonymous]
        public IActionResult InBox()
        {
            int id= 1;
            var values = message2Manager.GetInboxMessageByWriter(id);
            return View(values);
        }
        [AllowAnonymous]
        public IActionResult MessageDetails(int id)
        {
            var messagevalue = message2Manager.GetByClassID(id);
            return View(messagevalue);
        }
    }
}
