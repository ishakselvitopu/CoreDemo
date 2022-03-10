using BussinessLayer.Concrete;
using BussinessLayer.ValidationsRules;
using CoreDemo.Models;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{

    public class WriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }

        public IActionResult WriterMail()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var writerValues = writerManager.GetByClassID(1);
            return View(writerValues);
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterEditProfile(Writer writer)
        {
            WriterValidator validationRules = new WriterValidator();
            ValidationResult validationResult = validationRules.Validate(writer);
            if (validationResult.IsValid)
            {
                writerManager.Update(writer);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterImageAdd()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterImageAdd(AddProfilImage addProfilImage)
        {
            Writer writer = new Writer();
            if (addProfilImage.WriterImage != null)
            {
                var extesion = Path.GetExtension(addProfilImage.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extesion;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFile/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                addProfilImage.WriterImage.CopyTo(stream);
                writer.WriterImage = newimagename;
            }
            writer.WriterMail = addProfilImage.WriterMail;
            writer.WriterName = addProfilImage.WriterName;
            writer.WriterPassword = addProfilImage.WriterPassword;
            writer.WriterStatus = true;
            writer.WriterAbout = addProfilImage.WriterAbout;
            writerManager.Add(writer);
            return View();
        }
    }
}
