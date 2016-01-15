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
                var identifier = Driver.Instance.FindElements(By.XPath("//tab-heading[@class='ng-scope']"))[1];
                return identifier.Text == "Siiidenko A.O.";
            }
        }

        //public static bool ClickButton
        //{
        //    get
        //    {
        //        var button =
        //            Driver.Instance.FindElement(
        //                By.XPath("/html/body/div/div/div/div/div/div/div[2]/div/div/div/form/div/div/div[1]/div[1]"));
        //        if (button.Enabled) { return true;}
        //        else { throw new WebDriverException("Unexpected error");}
        //    }
        //}

        public static void DownloadPhoto()
        {
            Driver.Instance.FindElement(
                By.XPath("//input[@uploader='photoUploader']"))//browse
                .Click();

            SendKeys.SendWait(@"C:\Users\Public\Pictures\Sample Pictures\Koala.jpg");
            SendKeys.SendWait(@"{Enter}");

        }
    }
}