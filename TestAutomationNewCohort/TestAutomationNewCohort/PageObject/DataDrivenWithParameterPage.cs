﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationNewCohort.Utilities;

namespace TestAutomationNewCohort.PageObject
{
     class DataDrivenWithParameterPage
    {
        public DataDrivenWithParameterPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;
        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement Email => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(2) > input"));
        IWebElement Password => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(3) > input"));






        public void EnterUsername(string username)
        {
            Username.SendKeys(username);
        }

        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }


        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }



        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }





    }


}
