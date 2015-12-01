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

namespace QA_WORKS_ASSESSMENT.Support.PageObjects
{
    class QAWorks_ContactUs_PageObject
    {
        //Page Elements
        private static By name_textbox = By.XPath("//div[@id='ContactNameBox']/child::input");
        private static By email_textbox = By.XPath("//div[@id='ContactEmailBox']/child::input");
        private static By message_textarea = By.XPath("//div[@id='ContactMessageBox']/child::textarea");
        private static By send_button = By.XPath("//div[@id='ContactSend']/child::input");

        //Wait for page to load
        public void WaitForPageToLoad()
        {
            WebDriverWait wait = new WebDriverWait(Driver.CurrentDriver, TimeSpan.FromSeconds(30));
            IWebElement myWaitElement = wait.Until(d => d.FindElement(name_textbox));
        }

        //Page Object Methods
        public void EnterName(string name)
        {
            if (string.IsNullOrEmpty(name) == false)
            {
                Driver.CurrentDriver.FindElement(name_textbox).Click();
                Driver.CurrentDriver.FindElement(name_textbox).SendKeys(name);
            }
        }

        public void EnterEmailAddress(string email)
        {
            if (string.IsNullOrEmpty(email) == false)
            {
                Driver.CurrentDriver.FindElement(email_textbox).Click();
                Driver.CurrentDriver.FindElement(email_textbox).SendKeys(email);
            }
        }

        public void EnterMessage(string message)
        {
            if (string.IsNullOrEmpty(message) == false)
            {
                Driver.CurrentDriver.FindElement(message_textarea).Click();
                Driver.CurrentDriver.FindElement(message_textarea).SendKeys(message);
            }
        }

        public void ClickSend()
        {
            Driver.CurrentDriver.FindElement(send_button).Click();
        }
    }
}
