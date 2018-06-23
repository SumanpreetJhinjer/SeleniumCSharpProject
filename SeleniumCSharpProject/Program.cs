using NUnit.Framework;
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
        IWebDriver driver;
        static void Main(string[] args)
        {
            
        }
        [SetUp]
        public void Setup()
        {
            //reference for webdriver
            driver = new ChromeDriver();


            //Navigate to URL
            driver.Navigate().GoToUrl("https://www.google.com");
            Console.WriteLine("opened url");
        }
        [Test]
        public void ExecuteTest()
        {

            //enter text to some element
            IWebElement element = driver.FindElement(By.Name("q"));

            //action
            element.SendKeys("Sumanpreet Singh");
            Console.WriteLine("entered value");
        }
        [TearDown]
        public void TearDown()
        {
            //close browser
            driver.Close();
            Console.WriteLine("closed browser");
        }
    }
}
