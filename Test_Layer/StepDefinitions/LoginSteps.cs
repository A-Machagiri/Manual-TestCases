using TechTalk.SpecFlow;
using PageObjects.Login;
using Utilities.WebUtilities;

namespace Test_Layer.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private LoginPage loginPage;
        private WebUtilities webUtilities;

        public LoginSteps(WebUtilities utilities)
        {
            webUtilities = utilities;
            loginPage = new LoginPage(utilities);
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
    }
}