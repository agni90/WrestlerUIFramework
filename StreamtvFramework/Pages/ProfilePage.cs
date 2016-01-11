using System.Windows.Forms;
using OpenQA.Selenium;

namespace StreamtvFramework
{
    public class ProfilePage
    {
        public static bool IsAt
        {
            get
            {
                var identifier = Driver.Instance.FindElement(By.XPath("/html/body/div/div/div/div/div/ul/li[2]/a/tab-heading/div"));
                return identifier.Text == "Sidenko A.O.";
            }
        }

        public static void DownloadPhoto()
        {
            Driver.Instance.FindElement(
                By.XPath("/html/body/div/div/div/div/div/div/div[2]/div/div/div/form/div/div/div[3]/div/div[2]/input"))
                .Click();

            SendKeys.SendWait(@"C:\Users\Public\Pictures\Sample Pictures\Koala.jpg");
            SendKeys.SendWait(@"{Enter}");
        }
    }
}