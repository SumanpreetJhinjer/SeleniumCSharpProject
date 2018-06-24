using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpProject
{
    public static class CustomSetMethods
    {
        //enter text method
        /// <summary>
        /// Extension method for sending keys to the control
        /// </summary>
        /// <param name="element"></param>
        /// <param name="elementValue"></param>
        public static void EnterText(this IWebElement element, string elementValue)
        {
            element.SendKeys(elementValue);
        }
        //click on button, checkbox
        /// <summary>
        /// extension method to click the element
        /// </summary>
        /// <param name="element"></param>
        public static void Clicks(this IWebElement element)
        {
            element.Submit();
        }

        //select dropdown
        /// <summary>
        /// extension method to select from dropdown
        /// </summary>
        /// <param name="element"></param>
        /// <param name="elementValue"></param>
        public static void selectDropDown(this IWebElement element, string elementValue)
        {
            new SelectElement(element).SelectByText(elementValue);
        }
    }
}
