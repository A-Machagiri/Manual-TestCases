using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Test_Layer
{
    [Binding]
    public class LoginSteps
    {
        private readonly WebUtilities _webUtilities;

        public LoginSteps(WebUtilities webUtilities)
        {
            _webUtilities = webUtilities;
        }

        [Given("I navigate to the login page with URL '(.*)'")]
        public void GivenINavigateToTheLoginPageWithURL(string url)
        {
            _webUtilities.NavigateToUrl(url);
        }

        [When("I enter username '(.*)' and password '(.*)'")]
        public void WhenIEnterUsernameAndPassword(string username, string password)
        {
            _webUtilities.EnterText("username", username);
            _webUtilities.EnterText("password", password);
        }

        [Then("I should see the message '(.*)'")]
        public void ThenIShouldSeeTheMessage(string message)
        {
            _webUtilities.AssertText("message", message);
        }
    }
}