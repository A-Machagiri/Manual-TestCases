using OpenQA.Selenium;

namespace PageObjects.Login
{
    public partial class LoginPage
    {
        private By usernameLocator = By.Id("user-name");
        private By passwordLocator = By.Id("password");
        private By loginButtonLocator = By.Id("login-button");
        // Add locators for product page after login for assertion if needed
    }
}