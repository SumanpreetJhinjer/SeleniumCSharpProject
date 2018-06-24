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
    [Parallelizable]
    class Program :TestBase
    {
        
        static void Main(string[] args)
        {
            
        }
        //[SetUp]
        //public void SetupForTest()
        //{
        //    driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");

        //    Console.WriteLine("opened url");
        //}
        [Test]
        public void ExecuteTest()
        {
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");

             Console.WriteLine("opened url");
            //ExcelDataLib.PopulateInCollection(@"C:\Users\m\Documents");
            //Intilizing the page object for EALoginPage
            EALoginPOM eaLoginPage = new EALoginPOM( driver);
            // Intilizing the object of another page from the POM of Login page and entering credentials
            EAHomePOM homePage = eaLoginPage.Login(driver,"admin", "password");
            Console.WriteLine("Logged in");
            //Filling the form on home Page
            homePage.FillUserForm("Mr.", "Sumanpreet", "Singh", "Jhinjer");
            Console.WriteLine("Filled user form");

            
        }
        [Test]
        public void GoogleTest()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("Selenium");
            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.Name("btnK")).Submit();
            Assert.That( driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                                            "The text selenium doest not exist");

        }

    }
}
