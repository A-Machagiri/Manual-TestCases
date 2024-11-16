using OpenQA.Selenium;

namespace PageObjects.Login
{
    public partial class LoginPage_Locators
    {
        public By UsernameField => By.Id("username");
        public By PasswordField => By.Id("password");
        public By LoginButton => By.Id("login-button");
        public By ErrorMessage => By.CssSelector(".error-message");
        // Add locators for product page elements here
    }
}