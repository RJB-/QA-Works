using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using QA_WORKS_ASSESSMENT.Support.HelperObjects;
using OpenQA.Selenium.Support.UI;
using System.Configuration;

namespace QA_WORKS_ASSESSMENT.Support.PageObjects
{
    class QAWorks_HomePage_PageObject
    {
        //Variables
        public static string homepageUrl = (string)ConfigurationSettings.AppSettings["HomePage"];
        
        //Page Elements
        private static By contact_link = By.XPath("//ul[@id='menu']/child::li/child::a[contains(text(), 'Contact')]");


        //Wait for page to load
        public void WaitForPageToLoad()
        {
            WebDriverWait wait = new WebDriverWait(Driver.CurrentDriver, TimeSpan.FromSeconds(30));
            IWebElement myWaitElement = wait.Until(d => d.FindElement(contact_link));
        }

        //Page Object Methods
        public void ClickContactLink()
        {
            Driver.CurrentDriver.FindElement(contact_link).Click();
        }

        public void NavigateToHomePage()
        {
            Driver.CurrentDriver.Navigate().GoToUrl(homepageUrl);
        }
    }
}
