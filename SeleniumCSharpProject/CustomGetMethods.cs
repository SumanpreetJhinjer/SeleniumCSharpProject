using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpProject
{
    class CustomGetMethods
    {
        //get text from controls method
        public static string GetText(IWebDriver driver, string element, string elementType)
        {
            if (elementType.Equals("Id"))
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementType.Equals("Name"))
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            else return String.Empty;
        }

        //get text from controls like ddl method
        public static string GetTextDDL(IWebDriver driver, string element, string elementType)
        {
            if (elementType.Equals("Id"))
                return new SelectElement(driver.FindElement(By.Id(element))).SelectedOption.GetAttribute("value");
            if (elementType.Equals("Name"))
                return new SelectElement(driver.FindElement(By.Name(element))).SelectedOption.GetAttribute("value");
            else return String.Empty;
        }


    }
}
