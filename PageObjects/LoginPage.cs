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

        // Properties for elements on the login page will be added here
    }
}