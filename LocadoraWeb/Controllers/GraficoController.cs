using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocadoraWeb.Controllers
{
    public class GraficoController : Controller
    {
        [Authorize]
        public ActionResult AlocacaoMes()
        {
            return View();
        }

        [Authorize]
        public ActionResult PerdaMes()
        {
            return View();
        }

        [Authorize]
        public ActionResult FaturamentoMes()
        {
            return View();
        }
    }
}