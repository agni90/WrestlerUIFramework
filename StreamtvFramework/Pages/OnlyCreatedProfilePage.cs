using System.Runtime.Remoting.Messaging;
using System.Threading;
using OpenQA.Selenium;

namespace StreamtvFramework
{
    public class OnlyCreatedProfilePage
    {
        public static void Goto()
        {
            Driver.Instance.FindElement(
                By.XPath("/html/body/div/div/div/div/div/div/div/div/div/div[1]/div/form/div[1]/button[2]"))
                .Click();
        }

        public static CreateCommand CreateWithLastName(string lname)
        {
            return new CreateCommand(lname);
        }

        public static void Delete()
        {
            Driver.Instance.FindElement(
                By.XPath("/html/body/div/div/div/div/div/div/div[2]/div/div/div/form/div/div/div[1]/div[2]"))
                .Click();
            Thread.Sleep(2000);
            Driver.Instance.FindElement(
                By.XPath("/html/body/div[3]/div/div/div[3]/button[1]"))
                .Click();
        }
    }

    public class CreateCommand
    {
        private string _lname;
        private string _fname;
        private string _dob;
        private string _mname;
        private string _region;
        private string _fst;
        private string _style;
        private string _age;
        private string _year;

        public CreateCommand(string lname)
        {
            _lname = lname;
        }

        public CreateCommand WithFirstName(string fname)
        {
            _fname = fname;
            return this;
        }

        public CreateCommand WithDOB(string dob)
        {
            _dob = dob;
            return this;
        }

        public CreateCommand WithMiddleName(string mname)
        {
            _mname = mname;
            return this;
        }

        public CreateCommand WithRegion(string region)
        {
            _region = region;
            return this;
        }

        public CreateCommand WithFST(string fst)
        {
            _fst = fst;
            return this;
        }

        public CreateCommand WithStyle(string style)
        {
            _style = style;
            return this;
        }

        public CreateCommand WithAge(string age)
        {
            _age = age;
            return this;
        }

        public CreateCommand WithYear(string year)
        {
            _year = year;
            return this;            
        }


        public void Create()
        {
            var lname =
                Driver.Instance.FindElement(
                    By.XPath(
                        "/html/body/div/div/div/div/div/div/div[2]/div/div/div/form/div/div/div[2]/div/div[2]/div[1]/fg-input[1]/div/input"));
            lname.SendKeys(_lname);

            var fname = 
                Driver.Instance.FindElement(
                    By.XPath(
                        "/html/body/div/div/div/div/div/div/div[2]/div/div/div/form/div/div/div[2]/div/div[2]/div[1]/fg-input[2]/div/input"));
            fname.SendKeys(_fname);

            var dob =
                Driver.Instance.FindElement(
                    By.XPath(
                        "/html/body/div/div/div/div/div/div/div[2]/div/div/div/form/div/div/div[2]/div/div[2]/div[2]/fg-date/div/input"));
            dob.SendKeys(_dob);

            var mname =
                Driver.Instance.FindElement(
                    By.XPath(
                        "/html/body/div/div/div/div/div/div/div[2]/div/div/div/form/div/div/div[2]/div/div[2]/div[2]/fg-input/div/input"));
            mname.SendKeys(_mname);

            var region =
                Driver.Instance.FindElement(
                    By.XPath(
                        "/html/body/div/div/div/div/div/div/div[2]/div/div/div/form/div/div/div[2]/div/div[2]/div[3]/fg-select[1]/div/select/option[4]"));
            region.Click();

            var fst =
                Driver.Instance.FindElement(
                    By.XPath(
                        "/html/body/div/div/div/div/div/div/div[2]/div/div/div/form/div/div/div[2]/div/div[2]/div[4]/fg-select[1]/div/select/option[2]"));
            fst.Click();

            var fs =
                Driver.Instance.FindElement(
                    By.XPath(
                        "/html/body/div/div/div/div/div/div/div[2]/div/div/div/form/div/div/div[2]/div/div[2]/div[6]/fg-select[1]/div/select/option[2]"));
            fs.Click();

            var age =
                Driver.Instance.FindElement(
                    By.XPath(
                        "/html/body/div/div/div/div/div/div/div[2]/div/div/div/form/div/div/div[2]/div/div[2]/div[6]/fg-select[2]/div/select/option[4]"));
            age.Click();

            var year =
                Driver.Instance.FindElement(
                    By.XPath(
                        "/html/body/div/div/div/div/div/div/div[2]/div/div/div/form/div/div/div[2]/div/div[2]/div[7]/fg-select/div/select/option[2]"));
            year.Click();

            Thread.Sleep(2000);

            var greenButton =
                Driver.Instance.FindElement(
                    By.XPath("/html/body/div/div/div/div/div/div/div[2]/div/div/div/form/div/div/div[1]/div[1]/button"));
            greenButton.Click();

            Thread.Sleep(5000);

        }
    }

}