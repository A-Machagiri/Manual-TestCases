using OpenQA.Selenium;

namespace Utilities
{
    public class WebUtilities
    {
        private IWebDriver _driver;

        public WebUtilities(IWebDriver driver)
        {
            _driver = driver;
        }

        // Utility methods for WebDriver will be added here
    }
}