using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITUniver.TeleCalc.Web.Models
{
    public class CalcModel
    {
        [DisplayName("Операция")]
        public string OperName { get; set; }

        [HiddenInput(DisplayValue = false)]
        public SelectList OperaionList { get; set; }

        [Required(ErrorMessage = "Введите аргумент")]
        public double X { get; set; }

        [Required(ErrorMessage = "Введите аргумент")]
        public double Y { get; set; }

        [DisplayName("Результат")]
        [ReadOnly(true)]
        public double Result { get; set; }
        
    }
}