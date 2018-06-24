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
        [SetUp]
        public void SetupForTest()
        {
            CommonUtility.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");

            Console.WriteLine("opened url");
        }
        [Test]
        public void ExecuteTest()
        {
            
            //ExcelDataLib.PopulateInCollection(@"C:\Users\m\Documents");
            //Intilizing the page object for EALoginPage
            EALoginPOM eaLoginPage = new EALoginPOM();
            // Intilizing the object of another page from the POM of Login page and entering credentials
            EAHomePOM homePage = eaLoginPage.Login("admin", "password");
            Console.WriteLine("Logged in");
            //Filling the form on home Page
            homePage.FillUserForm("Mr.", "Sumanpreet", "Singh", "Jhinjer");
            Console.WriteLine("Filled user form");

            
        }
        [Test]
        public void Test2()
        {
            //Intilizing the page object for EALoginPage
            EALoginPOM eaLoginPage = new EALoginPOM();
            // Intilizing the object of another page from the POM of Login page and entering credentials
            EAHomePOM homePage = eaLoginPage.Login("admin", "password");
            Console.WriteLine("Logged in");
            //Filling the form on home Page
            homePage.FillUserForm("Mr.", "Sumanpreet", "Singh", "Jhinjer");
            Console.WriteLine("Filled user form");
        }
      
    }
}
