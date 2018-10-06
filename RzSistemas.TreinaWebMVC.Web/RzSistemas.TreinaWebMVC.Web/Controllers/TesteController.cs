using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;

namespace RzSistemas.TreinaWebMVC.Web.Controllers
{
    public class TesteController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}