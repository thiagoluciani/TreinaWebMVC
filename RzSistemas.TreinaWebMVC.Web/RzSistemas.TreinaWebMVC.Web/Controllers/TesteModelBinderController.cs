using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;
using RzSistemas.TreinaWebMVC.Web.Models;

namespace RzSistemas.TreinaWebMVC.Web.Controllers
{
    public class TesteModelBinderController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            ViewBag.Pessoa = pessoa;
            return View("Saudacao");
        }
    }
}