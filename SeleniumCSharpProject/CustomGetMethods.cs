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
        public static string GetText(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        //get text from controls like ddl method
        public static string GetTextDDL(this IWebElement element)
        {
            return new SelectElement(element).SelectedOption.GetAttribute("value");
        }


    }
}
