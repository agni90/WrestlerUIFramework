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

        public LoginCommand WithPassword(string password)
        {
            _password = password;
            return this;
        }

        public void Login()
        {
            var loginInput = Driver.Instance.FindElement(By.XPath("/html/body/div/div/div/div/div/div[2]/form/div[1]/fg-input/div/input"));
            loginInput.SendKeys(_username);

            var passInput = Driver.Instance.FindElement(By.XPath("/html/body/div/div/div/div/div/div[2]/form/div[2]/fg-input/div/input"));
            passInput.SendKeys(_password);

            var enterButton = Driver.Instance.FindElement(By.XPath("/html/body/div/div/div/div/div/div[2]/form/button"));
            enterButton.Click();
        }
    }
}
