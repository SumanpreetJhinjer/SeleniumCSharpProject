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
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public EAHomePOM Login(string userName,string password)
        {
            //Fill username
            txtUserName.SendKeys(userName);
            Console.WriteLine("User Name: " + txtUserName.GetAttribute("value"));
            //Fill password
            txtPassword.SendKeys(password);
            Console.WriteLine("Password: " + txtPassword.GetAttribute("value"));
            //Click Login
            btnLogin.Submit();
            // return the object of the page navigated to
            return new EAHomePOM();
        }
    }
}
