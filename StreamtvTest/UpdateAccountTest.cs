using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StreamtvFramework;

namespace StreamtvTest
{
    [TestClass]
    public class UpdateAccountTest : BaseTest
    {
        [TestMethod]
        public void Can_Update_Account()
        {
            #region TestData
            const string firstAndLastNames = "Sidenko Alexander";
            #endregion

            var searchPage = new SearchResultPage();
            var profilePage = new ProfilePage();
            searchPage.FillSearchField(firstAndLastNames);
            searchPage.SearchSubmit();
            searchPage.ChoosePersonFromSearchList();
            profilePage.ClickUploadPhotoButton();
            profilePage.ChoosePhotoFromPC();
            searchPage.GoToWrestlerTab();
            searchPage.SecondSearch();

            Assert.IsTrue(SearchResultPage.DoesPhotoLabelChanged, "Photo was not downloaded. Please, try again");
        }
    }
}
