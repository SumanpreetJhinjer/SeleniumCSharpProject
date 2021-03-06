﻿using OpenQA.Selenium;
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
        public EALoginPOM(IWebDriver driver)
        {
            PageFactory.InitElements(driver,this);
        }

        //use of FindsBy in POM
        [FindsBy(How =How.Name,Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public EAHomePOM Login(IWebDriver driver,string userName,string password)
        {
            //Fill username
            txtUserName.EnterText(userName);
            Console.WriteLine("User Name: " + txtUserName.GetText());
            //Fill password
            txtPassword.EnterText(password);
            Console.WriteLine("Password: " + txtPassword.GetText());
            //Click Login
            btnLogin.Clicks();
            // return the object of the page navigated to
            return new EAHomePOM( driver);
            
        }
    }
}
