using System;
using TechTalk.SpecFlow;
using TestProject1.PageObject;

namespace TestProject1.StepDefinition
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
        
        [Given(@"I click on sing up")]
        public void GivenIClickOnSingUp()
        {
            registrationPage.ClickOnSignUp();
        }
        
        [Given(@"I enter my Username")]
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
            registrationPage.ClickOnSignUpButton();
        }

        //[Then(@"I can register successfully")]
        //public void ThenICanRegisterSuccessfully()
        //{
        //    ScenarioContext.Current.Pending();
        //}
    }
}
