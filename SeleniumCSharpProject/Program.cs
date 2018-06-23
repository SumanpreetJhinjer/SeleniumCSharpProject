using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //reference for webdriver
            IWebDriver driver = new ChromeDriver();
            

            //Navigate to URL
            driver.Navigate().GoToUrl("https://www.google.com");

            //enter text to some element
            IWebElement element = driver.FindElement(By.Name("q"));

            //action
            element.SendKeys("Sumanpreet Singh");


        }
    }
}
