using OpenQA.Selenium;

namespace StreamtvFramework.Commands
{
    public class LoginCommand
    {
        private readonly string _username;
        private string _password;

        public LoginCommand(string username)
        {
            _username = username;
        }

        public LoginCommand EnterPassword(string password)
        {
            _password = password;
            return this;
        }

        public void Login()
        {
            var loginInput = Driver.Instance.FindElement(By.XPath("//input[@placeholder='Login']"));
            loginInput.SendKeys(_username);

            var passInput = Driver.Instance.FindElement(By.XPath("//input[@placeholder='Password']"));
            passInput.SendKeys(_password);

            var enterButton = Driver.Instance.FindElement(By.XPath("//button[@type='submit']"));
            enterButton.Click();
        }
    }
}
