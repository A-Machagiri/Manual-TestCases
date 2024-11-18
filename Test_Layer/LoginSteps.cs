using System;
using OpenQA.Selenium;
using PageObjects;

namespace Test_Layer
{
    public class LoginSteps
    {
        private WebUtilities _webUtilities;

        public LoginSteps(WebUtilities webUtilities)
        {
            _webUtilities = webUtilities;
        }

        using System;
using OpenQA.Selenium;
using PageObjects;
using FluentAssertions;

namespace Test_Layer
{
    public class LoginSteps
    {
        private WebUtilities _webUtilities;
        private LoginPage _loginPage;

        public LoginSteps(WebUtilities webUtilities)
        {
            _webUtilities = webUtilities;
            _loginPage = new LoginPage(_webUtilities.GetDriver());
        }

        public void PerformLogin(string username, string password)
        {
            _loginPage.EnterCredentials(username, password);
            _loginPage.ClickLoginButton();
        }

        public void VerifySuccessfulLogin()
        {
            var isLoggedIn = _loginPage.CheckIfLoggedIn();
            isLoggedIn.Should().BeTrue("because the credentials are correct");
        }
    }
}
    }
}