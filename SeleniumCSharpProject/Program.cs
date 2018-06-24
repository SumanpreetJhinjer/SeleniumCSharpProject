using NUnit.Framework;
using NUnit.Framework.Constraints;
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
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("opened url");
        }
        [Test]
        public void ExecuteTest()
        {

            //enter text to some element
            //IWebElement userName = driver.FindElement(By.Name("UserName"));
            //IWebElement password = driver.FindElement(By.Name("Password"));
            //IWebElement btnLogin = driver.FindElement(By.Name("Login"));


            //action
            //userName.SendKeys("admin");
            //password.SendKeys("admin");
            //btnLogin.Click();


            //Use of custom methods

            CustomSetMethods.EnterText(driver, "UserName", "admin", "Name");
            CustomSetMethods.EnterText(driver, "Password", "admin", "Name");
            CustomSetMethods.Click(driver, "Password", "Name");
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
