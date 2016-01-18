using System;
using OpenQA.Selenium;

namespace StreamtvFramework
{
    public class PersonsListPage
    {
        public static SearchPersonCommand EnterLastAndFirstNames(string lname)
        {
            return new SearchPersonCommand(lname);
        }

        public static void ChoosePersonFromSearchList()
        {
            Driver.Instance.FindElements(
                By.XPath("//td[@class='ng-binding']"))[1]//click to first name in table
                .Click();
        }

        public static void SecondSearch()
        {
            Driver.Instance.FindElement(
                By.XPath("//button[@type='submit']"))//click on search button
                .Click();
        }

        public static bool IsAtInEmptyTable
        {
            get
            {
                var fio =
                    Driver.Instance.FindElement(
                        By.XPath("//table[@class='table table-striped table-hover']"));//empty table
                return fio.Text == "Siiidenko Alexander Olegoeich";
            }
        }

        public static bool DoesPhotoLabelChanged
        {
            get
            {
                var photoLabel =
                    Driver.Instance.FindElements(
                        By.XPath("//td[@class='ng-binding']"))[5];//tab photo in user's card
                return photoLabel.Text == "Yes";
            }
        }

        public static bool IsAt {
            get
            {
                var fio =
                    Driver.Instance.FindElements(
                        By.XPath("//td[@class='ng-binding']"))[1];
                return fio.Text == "Siiidenko Alexander Olegoeich";
            }
        }

        public static bool IsAtOnEmptyTable
        {
            get
            {
                var emptyTable =
                    Driver.Instance.FindElement(
                        By.XPath("//table[@class='table table-striped table-hover']"));
                return emptyTable.Text == String.Empty;
            }
        }

        public static void GotoWreslerTab()
        {
            Driver.Instance.FindElement(
                By.XPath("//div[@class='tab-heading']")).Click();//go to wrestlers tab
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
                By.XPath("//input[@ng-model='searchFor']"));
            search.SendKeys(_lname);
            search.SendKeys(Keys.Enter);
        }
    }
}