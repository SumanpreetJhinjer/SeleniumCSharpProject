using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpProject
{
    class TestBase
    {

        [OneTimeSetUp]
        public void Setup()
        {
            //reference for webdriver
            CommonUtility.driver = new ChromeDriver();

            CommonUtility.driver.Manage().Window.Maximize();
            Console.WriteLine("Opened browser");

        }
        [OneTimeTearDown]
        public void TearDown()
        {
            //close browser
            CommonUtility.driver.Close();
            Console.WriteLine("closed browser");
        }
    }
}
