using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace QA_WORKS_ASSESSMENT.Support.HelperObjects
{
    class Driver
    {
        public static IWebDriver CurrentDriver { get; set; }
    }
}
