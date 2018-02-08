using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocadoraWeb.Controllers
{
    public class AlocacaoController : Controller
    {
        [Authorize]
        public ActionResult AlugaFilme()
        {
            return View();
        }

        [Authorize]
        public ActionResult LancaPerda()
        {
            return View();
        }

        [Authorize]
        public ActionResult InventariaEstoque()
        {
            return View();
        }
    }
}