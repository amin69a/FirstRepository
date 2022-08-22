using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public FileResult Test()
        {
            var fileByte = System.IO.File.ReadAllBytes("wwwroot/images/slider/1.jpg");
            const string FileName = "1.png";
            return File(fileByte, MediaTypeNames.Image.Jpeg, FileName);
        }
    }
}
