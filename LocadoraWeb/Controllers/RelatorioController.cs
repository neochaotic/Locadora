using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocadoraWeb.Controllers
{
    public class RelatorioController : Controller
    {
        [Authorize]
        public ActionResult TopFilmes()
        {
            return View();
        }

        [Authorize]
        public ActionResult Perdas()
        {
            return View();
        }
             
        
    }
}