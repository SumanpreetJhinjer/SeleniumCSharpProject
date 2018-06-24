using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpProject
{
    class CustomSetMethods
    {
        //enter text method
        public static void EnterText(IWebDriver driver, string element, string elementValue, string elementType)
        {
            if(elementType.Equals("Id"))
            driver.FindElement(By.Id(element)).SendKeys(elementValue);
            if (elementType.Equals("Name"))
                driver.FindElement(By.Name(element)).SendKeys(elementValue);
        }
        //click on button, checkbox
        public static void Click(IWebDriver driver, string element, string elementType)
        {
            if (elementType.Equals("Id"))
                driver.FindElement(By.Id(element)).Click();
            if (elementType.Equals("Name"))
                driver.FindElement(By.Name(element)).Click();
        }

        //select dropdown
        public static void selectDropDown(IWebDriver driver, string element, string elementValue, string elementType)
        {
            if (elementType.Equals("Id"))
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(elementValue);
            if (elementType.Equals("Name"))
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(elementValue);
        }
    }
}
