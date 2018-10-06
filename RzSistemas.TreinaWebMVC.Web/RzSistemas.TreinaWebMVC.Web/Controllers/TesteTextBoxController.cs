using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;

namespace RzSistemas.TreinaWebMVC.Web.Controllers
{
    public class TesteTextBoxController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string nome)
        {
            ViewBag.Mensagem = nome;
            return View("Saudacao");
        }
    }
}