using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITUniver.TeleCalc.Core;
using ITUniver.TeleCalc.Web.Models;

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
            var calc = new Calc();
            var Model = new CalcModel();
            Model.OperaionList = new SelectList(calc.returnOperationsName());
            ViewBag.OperList = calc.returnOperationsName();

            return View();
        }

        [HttpPost]
        public double Exec(CalcModel model)
        {
            if (Calc.returnOperationsName().Contains(model.OperName))
            {
                return Calc.Exec(model.OperName, model.X, model.Y);
            }

            return double.NaN;
        }

        [HttpGet]
        public ActionResult Index(string operName, double? x, double? y)
        {
            if (Calc.returnOperationsName().Contains(operName))
            {
                ViewBag.OperName = operName;
                ViewBag.X = x;
                ViewBag.Y = y;
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
            ViewBag.Oper = Calc.returnOperationsName();
            
            return View();
        }


    }
}