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
        public static void EnterText( string element, string elementValue, PropertyType elementType)
        {
            if(elementType.Equals(PropertyType.Id))
            CommonUtility.driver.FindElement(By.Id(element)).SendKeys(elementValue);
            if (elementType.Equals(PropertyType.Name))
                CommonUtility.driver.FindElement(By.Name(element)).SendKeys(elementValue);
        }
        //click on button, checkbox
        public static void Click( string element, PropertyType elementType)
        {
            if (elementType.Equals(PropertyType.Id))
                CommonUtility.driver.FindElement(By.Id(element)).Click();
            if (elementType.Equals(PropertyType.Name))
                CommonUtility.driver.FindElement(By.Name(element)).Click();
        }

        //select dropdown
        public static void selectDropDown( string element, string elementValue, PropertyType elementType)
        {
            if (elementType.Equals(PropertyType.Id))
                new SelectElement(CommonUtility.driver.FindElement(By.Id(element))).SelectByText(elementValue);
            if (elementType.Equals(PropertyType.Name))
                new SelectElement(CommonUtility.driver.FindElement(By.Name(element))).SelectByText(elementValue);
        }
    }
}
