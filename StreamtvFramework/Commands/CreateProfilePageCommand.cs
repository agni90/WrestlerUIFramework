using OpenQA.Selenium;

namespace StreamtvFramework.Commands
{
    public class CreateProfilePageCommand
    {
        private string _lname;
        private string _fname;
        private string _dob;
        private string _mname;
        private int _region;
        private int _fst;
        private int _style;
        private int _age;
        private int _year;

        readonly string _lnameXpath = "//input[@placeholder='Last name']";
        readonly string _fnameXpath = "//input[@placeholder='First name']";
        readonly string _dobXpath = "//input[@placeholder='Date of Birth']";
        readonly string _mnameXpath = "//input[@placeholder='Middle name']";
        readonly string _region1Xpath = "//fg-select[@value='wr.region1']//option[@value='string:13']";
        readonly string _fst1Xpath = "//fg-select[@value='wr.fst1']//option[@value='string:4']";
        readonly string _styleXpath = "//fg-select[@value='wr.style']//option[@value='string:2']";
        readonly string _lictypeXpath = "//fg-select[@value='wr.lictype']//option[@value='string:2']";
        readonly string _card_stateXpath = "//fg-select[@value='wr.expires']//option[@value='string:2015']";

        readonly string _greenButtonXPath = "//button[@ng-disabled='fWrestler.$invalid||fWrestler.$pristine']";
        readonly string _wrestlerTitle = "/html/body/div/div/div/div/div/ul/li[2]/a/tab-heading/div";

        public CreateProfilePageCommand EnterWrestler(Wrestler wrestler)
        {
            _lname = wrestler.lname;
            _fname = wrestler.fname;
            _dob = wrestler.dob;
            _mname = wrestler.mname;
            _region = wrestler.region1;
            _fst = wrestler.fst1;
            _style = wrestler.style;
            _age = wrestler.lictype;
            _year = wrestler.card_state;
            return this;
        }

        public void Create()
        {
            var lname = Driver.Instance.FindElement(By.XPath(_lnameXpath));
            lname.SendKeys(_lname);

            var fname = Driver.Instance.FindElement(By.XPath(_fnameXpath));
            fname.SendKeys(_fname);

            var dob = Driver.Instance.FindElement(By.XPath(_dobXpath));
            dob.SendKeys(_dob);

            var mname = Driver.Instance.FindElement(By.XPath(_mnameXpath));
            mname.SendKeys(_mname);

            Driver.Instance.FindElement(By.XPath(_region1Xpath)).Click();

            Driver.Instance.FindElement(By.XPath(_fst1Xpath)).Click();

            Driver.Instance.FindElement(By.XPath(_styleXpath)).Click();

            Driver.Instance.FindElement(By.XPath(_lictypeXpath)).Click();

            Driver.Instance.FindElement(By.XPath(_card_stateXpath)).Click();

            Driver.WaitElementUntilItVisible(_greenButtonXPath, 5);
            var greenButton =
                Driver.Instance.FindElement(
                    By.XPath(_greenButtonXPath));
            greenButton.Click();

            Driver.WaitElementUntilTextChanged(_wrestlerTitle, 5);
        }
    }
}
