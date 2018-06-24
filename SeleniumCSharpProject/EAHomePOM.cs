using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        public IWebElement ddlTitleId { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Male")]
        public IWebElement rbMale { get; set; }

        [FindsBy(How = How.Name, Using = "Female")]
        public IWebElement rbFemale { get; set; }

        [FindsBy(How = How.Name, Using = "english")]
        public IWebElement cbenglish { get; set; }

        [FindsBy(How = How.Name, Using = "Hindi")]
        public IWebElement cbHindi { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        //filling form on home page
        public void FillUserForm(string title, string initial, string firstName, string middleName)
        {
            //Use of extension methods
            //select title from drop down
            ddlTitleId.selectDropDown(title);
            //fill user info
            txtInitial.EnterText(initial);
            txtFirstName.EnterText(firstName);
            txtMiddleName.EnterText(middleName);
            //click gender radio button
            rbMale.Click();
            rbFemale.Click();
            //click language checkbox
            cbenglish.Click();
            cbHindi.Click();
            //click save
            Thread.Sleep(2000);
            btnSave.Click();
            
        }
    }
}
