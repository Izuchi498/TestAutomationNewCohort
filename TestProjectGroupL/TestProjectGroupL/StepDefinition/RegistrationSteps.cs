using System;
using TechTalk.SpecFlow;
using TestProjectGroupL.PageObject;

namespace TestProjectGroupL.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }




        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            registrationPage.NavigateToWebsite();
        }
        
        [Given(@"I click on sign up")]
        public void GivenIClickOnSignUp()
        {
            registrationPage.ClickOnSignUp();
        }
        
        [Given(@"I enter my username")]
        public void GivenIEnterMyUsername()
        {
            registrationPage.EnterUsername();
        }
        
        [Given(@"I enter my email")]
        public void GivenIEnterMyEmail()
        {
            registrationPage.EnterEmail();
        }
        
        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            registrationPage.EnterPassword();
        }
        
        [When(@"I click on the sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            registrationPage.ClickonSignUpButton();
        }
        
        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
