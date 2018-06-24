using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpProject
{
    //Enum for browserType
    public enum BrowerType
    {
        Chrome,
        Firefox,
        IE
    }

    public class TestBase : CommonUtility
    {
        private BrowerType _browserType;

        [SetUp]
        public void InitializeTest()
        {
            //Get the value from NUnit-console --params 
            //e.g. nunit3-console.exe --params:Browser=Firefox \SeleniumNUnitParam.dll
            //If nothing specified, test will run in Chrome browser
            var browserType = TestContext.Parameters.Get("Browser", "Chrome");
            //Parse the browser Type, since its Enum
            _browserType = (BrowerType)Enum.Parse(typeof(BrowerType), browserType);
            //Pass it to browser
            ChooseDriverInstance(_browserType);
        }

        private void ChooseDriverInstance(BrowerType browserType)
        {
            if (browserType == BrowerType.Chrome)
                driver = new ChromeDriver();
            else if (browserType == BrowerType.Firefox)
            {
                FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
                service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                service.HideCommandPromptWindow = true;
                service.SuppressInitialDiagnosticInformation = true;
                driver = new FirefoxDriver(service);
            }
            else if (browserType == BrowerType.IE)
            {
                driver = new InternetExplorerDriver();
            }
             driver.Manage().Window.Maximize();
             Console.WriteLine("Opened browser");
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
    //class TestBase :CommonUtility
    //{

    //    [OneTimeSetUp]
    //    public void Setup()
    //    {
    //        //reference for webdriver
    //        CommonUtility.driver = new ChromeDriver();

    //        CommonUtility.driver.Manage().Window.Maximize();
    //        Console.WriteLine("Opened browser");

    //    }
    //    [OneTimeTearDown]
    //    public void TearDown()
    //    {
    //        //close browser
    //        CommonUtility.driver.Close();
    //        Console.WriteLine("closed browser");
    //    }
    //}
}
