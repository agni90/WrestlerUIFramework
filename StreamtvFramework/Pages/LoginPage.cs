using StreamtvFramework.Commands;

namespace StreamtvFramework
{
    public class LoginPage
    {
        public static void Goto()
        {
            Driver.Instance.Navigate().GoToUrl("http://streamtv.net.ua/base");
        }

        public static LoginCommand EnterLogin(string username)
        {
            return new LoginCommand(username);
        }
    }
}