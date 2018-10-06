using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;

namespace RzSistemas.TreinaWebMVC.Web.Controllers
{
    public class TesteFormCollectionController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection formCollection)
        {
            string nome = formCollection["Nome"];
            ViewBag.Mensagem = nome;
            return View("Saudacao");
        }
    }
}