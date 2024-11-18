using OpenQA.Selenium;

namespace PageObjects.Login
{
    public partial class LoginPage
    {
        public By UsernameField => By.Id("user-name");
        public By PasswordField => By.Id("password");
        public By LoginButton => By.Id("login-button");
        public By ErrorMessage => By.CssSelector(".error-message-container.error");
        // Add locators for product page after login for assertion purposes
    }
}