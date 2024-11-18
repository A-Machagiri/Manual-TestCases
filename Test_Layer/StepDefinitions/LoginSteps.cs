// Test_Layer/StepDefinitions/LoginSteps.cs
using TechTalk.SpecFlow;
using YourNamespace.PageObjects.Login;
using YourNamespace.Utilities.WebUtilities;
using NUnit.Framework;

namespace YourNamespace.Test_Layer.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly WebUtilities webUtilities;
        private readonly LoginPage loginPage;

        public LoginSteps()
        {
            webUtilities = new WebUtilities();
            loginPage = new LoginPage(webUtilities);
        }

        [Given("I navigate to \"(.*)\"")]
        public void GivenINavigateTo(string url)
        {
            webUtilities.NavigateToUrl(url);
        }

        [When("I enter valid username \"(.*)\"")]
        public void WhenIEnterValidUsername(string username)
        {
            loginPage.EnterCredentials(username, null);
        }

        [When("I enter valid password \"(.*)\"")]
        public void WhenIEnterValidPassword(string password)
        {
            loginPage.EnterCredentials(null, password);
        }

        [When("I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            // Assuming the URL or some element on the products page is a marker of successful login
            Assert.IsTrue(webUtilities.CurrentUrl().Contains("inventory.html"), "Not redirected to products page.");
        }
    }
}