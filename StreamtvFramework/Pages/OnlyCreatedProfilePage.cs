﻿using System.Runtime.Remoting.Messaging;
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

        public static CreateCommand EnterLastName(string lname)
        {
            return new CreateCommand(lname);
        }

        public static void Delete()
        {
            Driver.Instance.FindElement(
                By.XPath("//button[@ng-disabled='wr.new']"))//red button was clicked
                .Click();
            //Thread.Sleep(2000);
            Driver.Instance.FindElement(
                By.XPath("//button[@class='btn btn-success']"))//dijsno pidverdutu pop up
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

        public CreateCommand EnterFirstName(string fname)
        {
            _fname = fname;
            return this;
        }

        public CreateCommand EnterDOB(string dob)
        {
            _dob = dob;
            return this;
        }

        public CreateCommand EnterMiddleName(string mname)
        {
            _mname = mname;
            return this;
        }

        public CreateCommand ChooseRegion(string region)
        {
            _region = region;
            return this;
        }

        public CreateCommand ChooseFST(string fst)
        {
            _fst = fst;
            return this;
        }

        public CreateCommand ChooseStyle(string style)
        {
            _style = style;
            return this;
        }

        public CreateCommand ChooseAge(string age)
        {
            _age = age;
            return this;
        }

        public CreateCommand ChooseYear(string year)
        {
            _year = year;
            return this;            
        }


        public void Create()
        {
            var lname =
                Driver.Instance.FindElement(
                    By.XPath("//input[@placeholder='Last name']"));
            lname.SendKeys(_lname);

            var fname = 
                Driver.Instance.FindElement(
                    By.XPath("//input[@placeholder='First name']"));
            fname.SendKeys(_fname);

            var dob =
                Driver.Instance.FindElement(
                    By.XPath("//input[@placeholder='Date of Birth']"));
            dob.SendKeys(_dob);

            var mname =
                Driver.Instance.FindElement(
                    By.XPath("//input[@placeholder='Middle name']"));
            mname.SendKeys(_mname);

            var findRegion = Driver.Instance.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div[2]/div/div/div/form/div/div/div[2]/div/div[2]/div[3]/fg-select[1]/div/select"));
            findRegion.Click();
            var region =
                Driver.Instance.FindElement(
                    By.XPath("//option[@label='Vynnitska']"));
            region.Click();

            var fst =
                Driver.Instance.FindElement(
                    By.XPath("//option[@label='Dinamo']"));
            fst.Click();

            var style =
                Driver.Instance.FindElement(
                    By.XPath("//option[@label='FS']"));
            style.Click();

            var age =
                Driver.Instance.FindElement(
                    By.XPath("//option[@label='Cadet']"));
            age.Click();

            var year =
                Driver.Instance.FindElement(
                    By.XPath("//option[@label='2017']"));
            year.Click();

            Thread.Sleep(2000);

            var greenButton =
                Driver.Instance.FindElement(
                    By.XPath("//ico[@icon='glyphicon-ok']"));
            greenButton.Click();

            Thread.Sleep(5000);

        }
    }

}