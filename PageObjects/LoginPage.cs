using OpenQA.Selenium;

namespace PageObjects
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private readonly WebUtilities _webUtilities;

        public LoginPage(IWebDriver driver, WebUtilities webUtilities)
        {
            _driver = driver;
            _webUtilities = webUtilities;
        }

        public void EnterUsername(string username)
        {
            _webUtilities.EnterText("username", username);
        }

        public void EnterPassword(string password)
        {
            _webUtilities.EnterText("password", password);
        }

        public void ClickLoginButton()
        {
            _webUtilities.Click("loginButton");
        }
    }
}