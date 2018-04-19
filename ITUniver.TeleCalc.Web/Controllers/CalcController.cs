using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITUniver.TeleCalc.Core;

namespace ITUniver.TeleCalc.Web.Controllers
{
    public class CalcController : Controller
    {
        [HttpGet]
        public ActionResult Index(string operName, double? x, double? y)
        {
            var calc = new Calc();
            var operations = calc.returnOperations();
            ViewBag.OperName = operName;
            ViewBag.X = x;
            ViewBag.Y = y;

            if (!string.IsNullOrEmpty(operName) && operations.Any(o => o.Name == operName))
            {
                ViewBag.Result = calc.Exec(operName, x ?? 0, y ?? 0);
            }
            
            

            return View();
        }

        [HttpGet]
        public ActionResult Operations()
        {
            var calc = new Calc();
            ViewBag.Oper = calc.returnOperationsName();


            return View();
        }


    }
}