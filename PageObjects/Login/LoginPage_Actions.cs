using YourNamespace.Utilities.WebUtilities;

namespace YourNamespace.PageObjects.Login
{
    public partial class LoginPage
    {
        private WebUtilities webUtilities;

        public LoginPage(WebUtilities utilities)
        {
            webUtilities = utilities;
        }

        public void EnterCredentials(string username, string password)
        {
            webUtilities.SendKeys(webUtilities.FindElement(usernameField), username);
            webUtilities.SendKeys(webUtilities.FindElement(passwordField), password);
        }

        public void ClickLoginButton()
        {
            webUtilities.Click(webUtilities.FindElement(loginButton));
        }

        // Add methods to interact with product page elements for assertion if needed
    }
}