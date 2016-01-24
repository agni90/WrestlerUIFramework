using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using StreamtvFramework.Commands;

namespace StreamtvFramework
{
    public class NewWrestlerPage
    {
        const string _lnameXpath = "//input[@placeholder='Last name']";
        const string _fnameXpath = "//input[@placeholder='First name']";
        const string _dobXpath = "//input[@placeholder='Date of Birth']";
        const string _mnameXpath = "//input[@placeholder='Middle name']";
        const string _region1Xpath = "//fg-select[@value='wr.region1']//option[@value='string:13']";
        const string _fst1Xpath = "//fg-select[@value='wr.fst1']//option[@value='string:4']";
        const string _styleXpath = "//fg-select[@value='wr.style']//option[@value='string:2']";
        const string _lictypeXpath = "//fg-select[@value='wr.lictype']//option[@value='string:2']";
        const string _card_stateXpath = "//fg-select[@value='wr.expires']//option[@value='string:2015']";

        const string _greenButtonXPath = "//button[@ng-disabled='fWrestler.$invalid||fWrestler.$pristine']";
        const string _wrestlerTitle = "/html/body/div/div/div/div/div/ul/li[2]/a/tab-heading/div";
        const string _newUserButtonXpath = "/html/body/div/div/div/div/div/div/div[1]/div/div/div[1]/div/form/div[1]/button[2]";

        [FindsBy(How = How.XPath, Using = _lnameXpath)]
        private IWebElement lnameElement { get; set; }

        [FindsBy(How = How.XPath, Using = _fnameXpath)]
        private IWebElement fnameElement { get; set; }

        [FindsBy(How = How.XPath, Using = _dobXpath)]
        private IWebElement dobElement { get; set; }

        [FindsBy(How = How.XPath, Using = _mnameXpath)]
        private IWebElement mnameElement { get; set; }

        [FindsBy(How = How.XPath, Using = _region1Xpath)]
        private IWebElement region1Element { get; set; }

        [FindsBy(How = How.XPath, Using = _fst1Xpath)]
        private IWebElement fst1Element { get; set; }

        [FindsBy(How = How.XPath, Using = _styleXpath)]
        private IWebElement styleElement { get; set; }

        [FindsBy(How = How.XPath, Using = _lictypeXpath)]
        private IWebElement lictypeElement { get; set; }

        [FindsBy(How = How.XPath, Using = _card_stateXpath)]
        private IWebElement card_stateElement { get; set; }

        [FindsBy(How = How.XPath, Using = _greenButtonXPath)]
        public IWebElement greenButtonElement { get; set; }

        [FindsBy(How = How.XPath, Using = _newUserButtonXpath)]
        private IWebElement newUserButton { get; set; }

        public NewWrestlerPage()
        {
            PageFactory.InitElements(Driver.Instance, this);
        }

        public void FillFields(Wrestler wrestler)
        {
            lnameElement.SendKeys(wrestler.lname);
            fnameElement.SendKeys(wrestler.fname);
            dobElement.SendKeys(wrestler.dob);
            mnameElement.SendKeys(wrestler.mname);
            region1Element.Click();
            fst1Element.Click();
            styleElement.Click();
            lictypeElement.Click();
            card_stateElement.Click();
        }

        public void SubmitNewWrestlerAccount()
        {
            greenButtonElement.Click();
        }

        public void WaitForWrestlerTitleChanged()
        {
            Driver.WaitElementUntilTextChanged(_wrestlerTitle, 5);
        }

        public void ClickNewUserButton()
        {
            newUserButton.Click();
            //Driver.Instance.FindElements(
            //    By.XPath("//button[@class='btn btn-default']"))[0]
            //    .Click();

            //"//button[@class='btn btn-default']//ico[@icon='glyphicon-plus']"
        }

    }
}