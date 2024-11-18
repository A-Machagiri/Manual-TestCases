using OpenQA.Selenium;
using Utilities.WebUtilities;

namespace PageObjects.Login
{
    public partial class LoginPage
    {
        private WebUtilities webUtilities;

        public LoginPage(WebUtilities utilities)
        {
            this.webUtilities = utilities;
        }

        public void EnterCredentials(string username, string password)
        {
            webUtilities.SendKeys(usernameLocator, username);
            webUtilities.SendKeys(passwordLocator, password);
        }

        public void ClickLoginButton()
        {
            webUtilities.Click(loginButtonLocator);
        }
    }
}