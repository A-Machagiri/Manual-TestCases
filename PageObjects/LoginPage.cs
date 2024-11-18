using OpenQA.Selenium;

namespace PageObjects
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private WebUtilities _webUtilities;

        public LoginPage(IWebDriver driver, WebUtilities webUtilities)
        {
            _driver = driver;
            _webUtilities = webUtilities;
        }

        using OpenQA.Selenium;

namespace PageObjects
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private WebUtilities _webUtilities;

        public LoginPage(IWebDriver driver, WebUtilities webUtilities)
        {
            _driver = driver;
            _webUtilities = webUtilities;
        }

        public static By UsernameField = By.Id("user-name");
        public static By PasswordField = By.Id("password");
        public static By LoginButton = By.Id("login-button");
        public static By ErrorMessage = By.CssSelector(".error-message-container");

        public void EnterCredentials(string username, string password)
        {
            _webUtilities.SendKeys(UsernameField, username);
            _webUtilities.SendKeys(PasswordField, password);
        }

        public void ClickLoginButton()
        {
            _webUtilities.Click(LoginButton);
        }
    }
}
    }
}