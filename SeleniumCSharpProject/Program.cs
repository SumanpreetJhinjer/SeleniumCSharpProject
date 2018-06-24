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
        
        static void Main(string[] args)
        {
            
        }
        [SetUp]
        public void Setup()
        {
            //reference for webdriver
            CommonUtility.driver = new ChromeDriver();


            //Navigate to URL
            CommonUtility.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("opened url");
        }
        [Test]
        public void ExecuteTest()
        {
            //Intilizing the page object for EALoginPage
            EALoginPOM eaLoginPage = new EALoginPOM();
            // Intilizing the object of another page from the POM of Login page and entering credentials
            EAHomePOM homePage = eaLoginPage.Login("admin", "password");
            Console.WriteLine("Logged in");
            //Filling the form on home Page
            homePage.FillUserForm("Mr.", "Sumanpreet", "Singh", "Jhinjer");
            Console.WriteLine("Filled user form");

            ////Use of set custom methods

            //CustomSetMethods.EnterText( "UserName", "admin", PropertyType.Name);
            //CustomSetMethods.EnterText( "Password", "admin", PropertyType.Name);

            ////Get custom methods
            //Console.WriteLine("User Name: " + CustomGetMethods.GetText( "UserName", PropertyType.Name));
            //Console.WriteLine("Password: " + CustomGetMethods.GetText( "Password", PropertyType.Name));
            //CustomSetMethods.Click( "Login", PropertyType.Name);
            //Console.WriteLine("entered value");
        }
        [TearDown]
        public void TearDown()
        {
            //close browser
            CommonUtility.driver.Close();
            Console.WriteLine("closed browser");
        }
    }
}
