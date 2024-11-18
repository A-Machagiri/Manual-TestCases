using NUnit.Framework;
using PageObjects.Login;
using System;
using TechTalk.SpecFlow;
using Utilities.WebUtilities;

namespace Test_Layer.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private LoginPage loginPage;
        private readonly ScenarioContext _scenarioContext;

        public LoginSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            var webUtilities = (WebUtilities)_scenarioContext["WebUtilities"];
            loginPage = new LoginPage(webUtilities);
        }

        [Given("I navigate to \"(.*)\"")]
        public void GivenINavigateTo(string url)
        {
            loginPage.webUtilities.NavigateToUrl(url);
        }

        [When("I enter valid username \"(.*)\"")]
        public void WhenIEnterValidUsername(string username)
        {
            loginPage.EnterCredentials(username, "secret_sauce");
        }

        [When("I enter valid password \"(.*)\"")]
        public void WhenIEnterValidPassword(string password)
        {
            loginPage.EnterCredentials("standard_user", password);
        }

        [When("I enter invalid username \"(.*)\"")]
        public void WhenIEnterInvalidUsername(string username)
        {
            loginPage.EnterCredentials(username, "secret_sauce");
        }

        [When("I enter invalid password \"(.*)\"")]
        public void WhenIEnterInvalidPassword(string password)
        {
            loginPage.EnterCredentials("standard_user", password);
        }

        [When("I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            Assert.IsTrue(loginPage.webUtilities.FindElement(loginPage.ProductPageElement).Displayed);
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            Assert.IsTrue(loginPage.webUtilities.FindElement(loginPage.ErrorMessage).Displayed);
        }
    }
}