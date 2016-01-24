using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace StreamtvFramework
{
    public class ProfilePage
    {
        const string _wrestlerTitleXpath = "/html/body/div/div/div/div/div/ul/li[2]/a/tab-heading/div";
        const string _deleteUserButtonXpath = "//button[@ng-disabled='wr.new']";
        const string _popupXpath = "//button[@class='btn btn-success']";
        const string _photoUploaderXpath = "//input[@uploader='photoUploader']";

        [FindsBy(How = How.XPath, Using = _wrestlerTitleXpath)]
        public IWebElement wrestlerTitleElement { get; set; }

        [FindsBy(How = How.XPath, Using = _deleteUserButtonXpath)]
        public IWebElement deleteUserButton { get; set; }

        [FindsBy(How = How.XPath, Using = _popupXpath)]
        public IWebElement popupConfirmation { get; set; }

        [FindsBy(How = How.XPath, Using = _photoUploaderXpath)]
        public IWebElement uploadPhotoButton { get; set; }

        public ProfilePage()
        {
            PageFactory.InitElements(Driver.Instance, this);
        }

        public void DeleteWrestler()
        {
            deleteUserButton.Click();
        }

        public void ConfirmDeleteUser()
        {
            popupConfirmation.Click();
        }

        public void ClickUploadPhotoButton()
        {
            uploadPhotoButton.Click();
        }

        public void ChoosePhotoFromPC()
        {
            SendKeys.SendWait(@"C:\Users\Inga\Desktop\ZuwvhdFGb8k.jpg");
            SendKeys.SendWait(@"{Enter}");
        }

    }
}