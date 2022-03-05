using BussinessLayer.Concrete;
using BussinessLayer.ValidationsRules;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            ContactValidator validationRules = new ContactValidator();
            ValidationResult validationResult = validationRules.Validate(contact);
            if (validationResult.IsValid)
            {
                contact.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                contact.ContactStatus = true;
                contactManager.ContactAdd(contact);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return RedirectToAction("Error1","ErrorPageContorller");
        }
    }
}
