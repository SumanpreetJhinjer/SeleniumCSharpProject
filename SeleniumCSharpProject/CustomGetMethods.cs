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
        public static string GetText( string element, PropertyType elementType)
        {
            if (elementType.Equals(PropertyType.Id))
                return CommonUtility.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementType.Equals(PropertyType.Name))
                return CommonUtility.driver.FindElement(By.Name(element)).GetAttribute("value");
            else return String.Empty;
        }

        //get text from controls like ddl method
        public static string GetTextDDL( string element, PropertyType elementType)
        {
            if (elementType.Equals(PropertyType.Id))
                return new SelectElement(CommonUtility.driver.FindElement(By.Id(element))).SelectedOption.GetAttribute("value");
            if (elementType.Equals(PropertyType.Name))
                return new SelectElement(CommonUtility.driver.FindElement(By.Name(element))).SelectedOption.GetAttribute("value");
            else return String.Empty;
        }


    }
}
