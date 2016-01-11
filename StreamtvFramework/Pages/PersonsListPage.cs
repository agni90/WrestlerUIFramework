﻿using System.Threading;
using OpenQA.Selenium;

namespace StreamtvFramework
{
    public class PersonsListPage
    {
        public static SearchPersonCommand SearchPerson(string lname)
        {
            return new SearchPersonCommand(lname);
        }

        public static void ChoosePerson()
        {
            Driver.Instance.FindElement(
                By.XPath("/html/body/div/div/div/div/div/div/div/div/div/div[3]/div[2]/table/tbody/tr/td[2]"))
                .Click();
            Thread.Sleep(2000);
        }

        public static void SecondSearch()
        {
            Driver.Instance.FindElement(
                By.XPath("/html/body/div/div/div/div/div/div/div/div/div/div[1]/div/form/div[1]/button[1]"))
                .Click();
        }

        public static bool IsAtInEmptyTable
        {
            get
            {
                var fio =
                    Driver.Instance.FindElement(
                        By.XPath("/html/body/div/div/div/div/div/div/div/div/div/div[3]/div[2]/table"));
                return fio.Text == "Sidenko Alexander Olegoeich";
            }
        }

        public static bool DoesPhotoLabelChanged
        {
            get
            {
                var photoLabel =
                    Driver.Instance.FindElement(
                        By.XPath("/html/body/div/div/div/div/div/div/div[1]/div/div/div[3]/div[2]/table/tbody/tr/td[6]"));
                return photoLabel.Text == "Yes";
            }
        }

        public static bool IsAt {
            get
            {
                var fio =
                    Driver.Instance.FindElement(
                        By.XPath("/html/body/div/div/div/div/div/div/div/div/div/div[3]/div[2]/table/tbody/tr/td[2]"));
                return fio.Text == "Sidenko Alexander Olegoeich";
            }
        }

        public static void Goto()
        {
            Driver.Instance.FindElement(
                By.XPath("/html/body/div/div/div/div/div/ul/li[1]/a/tab-heading/div")).Click();


        }
    }

    public class SearchPersonCommand
    {
        private string _lname;

        public SearchPersonCommand(string lname)
        {
            _lname = lname;
        }

        public SearchPersonCommand SearchPerson(string lname)
        {
            _lname = lname;
            return new SearchPersonCommand(lname);
        }

        public void Search()
        {
            var search = Driver.Instance.FindElement(
                By.XPath("/html/body/div/div/div/div/div/div/div/div/div/div[1]/div/form/div[1]/input"));
            search.SendKeys(_lname);
            search.SendKeys(Keys.Enter);
        }
    }
}