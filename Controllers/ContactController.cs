using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarGallery.Models;

namespace CarGallery.Controllers
{
    public class ContactController : Controller
    {
        public ContactController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromBody] Contact model)
        {
            return Json(new
            {
                Message = "Ok"
            });
        }

    }
}