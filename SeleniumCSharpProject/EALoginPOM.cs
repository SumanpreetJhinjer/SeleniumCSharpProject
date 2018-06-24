using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpProject
{
    class EALoginPOM
    {
        public EALoginPOM()
        {
            PageFactory.InitElements(CommonUtility.driver,this);
        }

        //use of FindsBy in POM
        [FindsBy(How =How.Name,Using = "UserName")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement Login { get; set; }
    }
}
