using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace StreamtvFramework
{
    public class SearchResultPage
    {
        const string _searchUserFieldXpath = "//input[@ng-model='searchFor']";
        const string _wrestlerTabXpath = "//div[@class='tab-heading']";

        [FindsBy(How = How.XPath, Using = _searchUserFieldXpath)]
        private IWebElement searchUserField { get; set; }

        [FindsBy(How = How.XPath, Using = _wrestlerTabXpath)]
        private IWebElement wrestlerTab { get; set; }

        public SearchResultPage()
        {
            PageFactory.InitElements(Driver.Instance, this);
        }

        public void FillSearchField(string searchParams)
        {
            searchUserField.SendKeys(searchParams);
        }

        public void SearchSubmit()
        {
            searchUserField.SendKeys(Keys.Enter);
        }

        public void GoToWrestlerTab()
        {
            wrestlerTab.Click();
        }

        public static string FirstLine
        {
            get
            {
                var fio =
                    Driver.Instance.FindElements(
                        By.XPath("//td[@class='ng-binding']"))[1];
                return fio.Text;
            }
        }
        public static string IsAtOnEmptyTable
        {
            get
            {
                var emptyTable =
                    Driver.Instance.FindElement(
                        By.XPath("//table[@class='table table-striped table-hover']"));
                return emptyTable.Text;
            }
        }
        public void ChoosePersonFromSearchList()
        {
            Driver.Instance.FindElements(
                By.XPath("//td[@class='ng-binding']"))[1]
                .Click();
        }
        public void SecondSearch()
        {
            Driver.Instance.FindElement(
                By.XPath("//button[@type='submit']"))
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
                        By.XPath("//td[@class='ng-binding']"))[5];
                return photoLabel.Text == "Yes";
            }
        }
    }
}

