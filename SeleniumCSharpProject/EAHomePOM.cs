using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpProject
{
    class EAHomePOM
    {
        public EAHomePOM()
        {
            PageFactory.InitElements(CommonUtility.driver, this);
        }

        //use of FindsBy in POM
        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement TitleId { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement Initial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement MiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Male")]
        public IWebElement Male { get; set; }

        [FindsBy(How = How.Name, Using = "Female")]
        public IWebElement Female { get; set; }

        [FindsBy(How = How.Name, Using = "english")]
        public IWebElement english { get; set; }

        [FindsBy(How = How.Name, Using = "Hindi")]
        public IWebElement Hindi { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement Save { get; set; }
    }
}
