using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpProject
{
    public static class CustomGetMethods
    {
        //get text from controls method
        /// <summary>
        /// extension of get attribute method
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static string GetText(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        //get text from controls like ddl method
        /// <summary>
        /// extension of get attribute from drop down method
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static string GetTextDDL(this IWebElement element)
        {
            return new SelectElement(element).SelectedOption.GetAttribute("value");
        }


    }
}
