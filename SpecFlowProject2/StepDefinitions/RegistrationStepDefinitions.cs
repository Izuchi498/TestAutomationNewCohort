using SpecFlowProject2.PageObject;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class RegistrationStepDefinitions
    {

        RegistrationPage registrationPage;

        public RegistrationStepDefinitions() 
        { 
            registrationPage = new RegistrationPage();
        }
        







        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            registrationPage.NavigateToWebsite();
        }

        [Given(@"I enter first name")]
        public void GivenIEnterFirstName()
        {
           registrationPage.EnterFirstName ();
        }

        [Given(@"I enter last name")]
        public void GivenIEnterLastName()
        {
            registrationPage.EnterLastName();
        }

        [Given(@"I enter  address")]
        public void GivenIEnterAddress()
        {
            registrationPage.EnterAddress();
        }

        [Given(@"I enter email address")]
        public void GivenIEnterEmailAddress()
        {
            registrationPage.EnterEmailAddress();
        }

        [Given(@"I enter phone number")]
        public void GivenIEnterPhoneNumber()
        {
            registrationPage.EnterPhoneNumber();
        }

        [Given(@"I enter gender")]
        public void GivenIEnterGender()
        {
            registrationPage.EnterGender();
        }

        [Given(@"I enter hobbies")]
        public void GivenIEnterHobbies()
        {
            registrationPage.EnterHobbies();
        }

        [Given(@"I enter languages")]
        public void GivenIEnterLanguages()
        {
           registrationPage.EnterLanguages();
        }

        [Given(@"I enter skills")]
        public void GivenIEnterSkills()
        {
            registrationPage.EnterSkills();
        }

        [Given(@"I enter country")]
        public void GivenIEnterCountry()
        {
            registrationPage.EnterCountry();
        }

        [Given(@"I enter date of birth")]
        public void GivenIEnterDateOfBirth()
        {
            registrationPage.EnterDateOfBirth();
        }

        [Given(@"I enter password")]
        public void GivenIEnterPassword()
        {
          registrationPage.EnterPassword();
        }

        [Given(@"I enter confirm password")]
        public void GivenIEnterConfirmPassword()
        {
            registrationPage.EnterConfirmPassword();
        }

        [When(@"I click on submit")]
        public void WhenIClickOnSubmit()
        {
            throw new PendingStepException();
        }

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
