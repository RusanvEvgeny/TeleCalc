using ITUniver.TeleCalc.Core;
using ITUniver.TeleCalc.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITUniver.TeleCalc.Web.Controllers
{
    public class CalcController : Controller
    {
        private Calc Calc { get; set; }

        public CalcController()
        {
            Calc = new Calc();
        }

        [HttpGet]
        public ActionResult Exec()
        {
            var model = new CalcModel();

            model.OperationList = new SelectList(Calc.GetOperNames());

            return View(model);
        }

        [HttpPost]
        public double Exec(CalcModel model)
        {
            if (Calc.GetOperNames().Contains(model.OperName))
            {
                return Calc.Exec(model.OperName, model.X, model.Y);
            }
            return double.NaN;
        }

        [HttpGet]
        public ActionResult Index(string operName, double? x, double? y)
        {
            if (Calc.GetOperNames().Contains(operName))
            {
                ViewBag.OperName = operName;
                ViewBag.x = x;
                ViewBag.y = y;
                ViewBag.Result = Calc.Exec(operName, x ?? 0, y ?? 0);
            }
            else
            {
                ViewBag.Error = "Укажите операцию";
            }

            return View();
        }

        public ActionResult Operations()
        {
            ViewBag.Operations = Calc.GetOperNames();
            return View("Ops");
        }
    }
}