using System;
using System.Security.Cryptography.X509Certificates;
using TechTalk.SpecFlow;
using TestAutomationNewCohort.PageObject;

namespace TestAutomationNewCohort.StepDefinitions
{ 

}

    [Binding]
    public class DataDrivenWithParameterStepDefinitions
    {
        DataDrivenWithParameterPage dataDrivenWithParameterPage;


        public DataDrivenWithParameterStepDefinitions()
        
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();












        }

        [Given(@"I navigate to ""([^""]*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebsite(url);
        }

        [Given(@"I enter my Username ""([^""]*)""")]
        public void GivenIEnterMyUsername(string username)
        {
            dataDrivenWithParameterPage.EnterUsername(username);
        }

        [Given(@"I enter my Email ""([^""]*)""")]
        public void GivenIEnterMyEmail(string email)
        {
            dataDrivenWithParameterPage.EnterEmail(email);
        }

        [Given(@"I enter my password ""([^""]*)""")]
        public void GivenIEnterMyPassword(string password)
        {
            dataDrivenWithParameterPage.EnterPassword(password);
        }





}







