using NUnit.Framework;
using OpenQA.Selenium;
using PageObjects;

namespace Test_Layer
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver _driver;
        private LoginPage _loginPage;

        public LoginSteps()
        {
            _driver = WebUtilities.GetDriver();
            _loginPage = new LoginPage(_driver);
        }

        [Given("I navigate to the login page")]
        public void GivenINavigateToTheLoginPage()
        {
            _loginPage.NavigateToLoginPage();
        }

        [When("I enter username '(.*)' and password '(.*)'")]
        public void WhenIEnterUsernameAndPassword(string username, string password)
        {
            _loginPage.EnterUsername(username);
            _loginPage.EnterPassword(password);
        }

        [When("I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            Assert.IsTrue(_loginPage.IsAtProductsPage());
        }

        [Then("an error message should be displayed indicating (.*)")]
        public void ThenAnErrorMessageShouldBeDisplayed(string message)
        {
            Assert.IsTrue(_loginPage.IsErrorMessageDisplayed(message));
        }
    }
}