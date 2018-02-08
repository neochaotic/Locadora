using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocadoraWeb.Controllers
{
    public class CadastroController : Controller
    {
        [Authorize]
        public ActionResult Filme()
        {
            return View();
        }

        [Authorize]
        public ActionResult Cliente()
        {
            return View();
        }

        [Authorize]
        public ActionResult PerfilUsuario()
        {
            return View();
        }

        [Authorize]
        public ActionResult Usuario()
        {
            return View();
        }
    }
}