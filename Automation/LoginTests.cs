// NUnit Test Cases for Login

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[TestFixture]
public class LoginTests
{
    private IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.saucedemo.com/");
    }

    [Test]
    public void TestValidLogin()
    {
        LoginPage loginPage = new LoginPage(driver);
        loginPage.Login("standard_user", "secret_sauce");
        // Asserts to be added
    }

    [TearDown]
    public void Teardown()
    {
        driver.Quit();
    }
}