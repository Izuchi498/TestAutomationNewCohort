using OpenQA.Selenium;
using SpecFlowProject2.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2.PageObject
{
     class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement FirstName => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(2) > input"));
        IWebElement LastName => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(3) > input"));
        IWebElement Address => driver.FindElement(By.XPath("//*[@id=\"basicBootstrapForm\"]/div[2]/label"));
        IWebElement EmailAddress => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(3) > label"));
        IWebElement PhoneNumber => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(4) > label"));
        IWebElement Gender => driver.FindElement(By.XPath("//*[@id=\"basicBootstrapForm\"]/div[5]/label"));
        IWebElement Hobbies => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(6) > label"));
        IWebElement Languages => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(6) > label"));
        IWebElement Skills => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(8) > label"));
        IWebElement Country => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(9) > label"));
        IWebElement Dateofbirth => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(11) > label"));
        IWebElement Password => driver.FindElement(By.XPath("//*[@id=\"basicBootstrapForm\"]/div[12]/label"));
        IWebElement ConfirmPassword => driver.FindElement(By.CssSelector("//*[@id=\"basicBootstrapForm\"]/div[13]/label"));
        




        public void EnterFirstName() 
        {
            FirstName.SendKeys("Blessed");
        }
       

        public void EnterLastName() 
        {
            LastName.SendKeys("Beautiful");
        }
        
        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://demo.automationtesting.in/Register.html");
        }


        public void EnterAddress()
        {
            Address.SendKeys("16 Bosworth street");
        }
        
        public void EnterEmailAddress()
        {
            EmailAddress.SendKeys("Dejavu@ymail.com");
        }


        public void EnterPhoneNumber()
        {
            PhoneNumber.SendKeys("07608687716");
        }


        public void EnterGender()
        {
            Gender.SendKeys("Female");
        }

        public void EnterHobbies()
        {
            Hobbies.SendKeys("Beauty");
        }

        public void EnterLanguages()
        {
            Languages.SendKeys("IBO");
        }

        public void SelectSkills()
        {
            Skills.SendKeys("Automation");
        }

        public void SelectCountry()
        {
            Country.SendKeys("UnitedKingdom");
        }

        public void EnterDateOfBirth()
        {
            Dateofbirth.SendKeys("26June1900");
        }

        public void EnterPassword()
        {
            Password.SendKeys("PasswordSecure");
        }

        public void EnterConfirmPassword()
        {
            ConfirmPassword.SendKeys("Password123");
        }






             
                
        
             
        

        








    }
}
