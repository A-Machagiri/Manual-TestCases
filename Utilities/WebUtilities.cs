using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Utilities
{
    public static class WebUtilities
    {
        public static IWebDriver GetDriver()
        {
            return new ChromeDriver();
        }
    }
}