using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StreamtvFramework;

namespace StreamtvTest
{
    [TestClass]
    public class DeleteAccountTest : BaseTest
    {
        [TestMethod]
        public void Can_Delete_Account()
        {
            #region TestData
            const string firstAndLastNames = "Siiidenko Alexander";
            #endregion

            var searchPage = new SearchResultPage();
            var profilePage = new ProfilePage();

            searchPage.FillSearchField(firstAndLastNames);
            searchPage.SearchSubmit();
            searchPage.ChoosePersonFromSearchList();
            profilePage.DeleteWrestler();
            profilePage.ConfirmDeleteUser();
            searchPage.SecondSearch();

            Assert.IsFalse(SearchResultPage.IsAtInEmptyTable, "Your account was not deleted");
        }
    }
}
