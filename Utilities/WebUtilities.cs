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

        public void NavigateToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void EnterText(string elementId, string text)
        {
            _driver.FindElement(By.Id(elementId)).SendKeys(text);
        }

        public void Click(string elementId)
        {
            _driver.FindElement(By.Id(elementId)).Click();
        }

        public void AssertText(string elementId, string expectedText)
        {
            var actualText = _driver.FindElement(By.Id(elementId)).Text;
            if (actualText != expectedText)
                throw new Exception("Assertion failed. Expected: " + expectedText + ", Actual: " + actualText);
        }
    }
}