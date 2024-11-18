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
            webUtilities.SendKeys(webUtilities.FindElement(UsernameField), username);
            webUtilities.SendKeys(webUtilities.FindElement(PasswordField), password);
        }

        public void ClickLoginButton()
        {
            webUtilities.Click(webUtilities.FindElement(LoginButton));
        }

        // Add methods to interact with product page elements for assertions
    }
}