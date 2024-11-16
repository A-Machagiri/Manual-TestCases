using OpenQA.Selenium;

namespace PageObjects.Login
{
    public partial class LoginPage_Actions
    {
        private readonly IWebDriver driver;
        private readonly LoginPage_Locators locators;

        public LoginPage_Actions(IWebDriver driver)
        {
            this.driver = driver;
            locators = new LoginPage_Locators();
        }

        public void EnterCredentials(string username, string password)
        {
            driver.FindElement(locators.UsernameField).SendKeys(username);
            driver.FindElement(locators.PasswordField).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(locators.LoginButton).Click();
        }

        public string GetErrorMessage()
        {
            return driver.FindElement(locators.ErrorMessage).Text;
        }

        // Add methods to interact with product page elements here
    }
}