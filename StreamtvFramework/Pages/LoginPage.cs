using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace StreamtvFramework
{
    public class LoginPage
    {
        const string _usernameXpath = "//input[@placeholder='Login']";
        const string _passwordXpath = "//input[@placeholder='Password']";
        const string _submitButtonXpath = "//button[@type='submit']";

        [FindsBy(How = How.XPath, Using = _usernameXpath)]
        public IWebElement usernameElement { get; set; }

        [FindsBy(How = How.XPath, Using = _passwordXpath)]
        public IWebElement passwordElement { get; set; }

        [FindsBy(How = How.XPath, Using = _submitButtonXpath)]
        public IWebElement submitButton { get; set; }

        public LoginPage()
        {
            PageFactory.InitElements(Driver.Instance, this);
        }

        public void GotoLoginPage()
        {
            Driver.Instance.Navigate().GoToUrl("http://streamtv.net.ua/base");
        }

        public void EnterLogin(string login)
        {
            usernameElement.SendKeys(login);
        }

        public void EnterPassword(string password)
        {
            passwordElement.SendKeys(password);
        }

        public void SubmitWrestlerCreation()
        {
            submitButton.Click();
        }
    }
}