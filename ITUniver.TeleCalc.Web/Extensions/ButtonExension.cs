using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITUniver.TeleCalc.Web.Extensions
{
    public static class ButtonExension
    {
        /// <summary>
        /// Сгенерировать нопку для отправки формы с заданым именем
        /// </summary>
        /// <param name="html"></param>
        /// <param name="name">Название кнопки</param>
        /// <returns>html-разметка</returns>
        public static MvcHtmlString Submit(this HtmlHelper html, string name, string oneclick)
        {
            TagBuilder button = new TagBuilder("input");
            button.AddCssClass("btn btn-defalt");
            button.Attributes["type"] = "submit";
            button.Attributes["value"] = name;
            button.Attributes["oneclick"] = oneclick;
            
            return new MvcHtmlString(button.ToString());
        }
    }
}