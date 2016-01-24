using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StreamtvFramework;

namespace StreamtvTest
{
	[TestClass]
	public class SearchUserTest : BaseTest
	{
		[TestMethod]
		public void Can_Search_User()
		{
            #region TestData
            const string firstAndLastNames = "Sidenko Alexander";
            #endregion

            var searchPage = new SearchResultPage();
            searchPage.FillSearchField(firstAndLastNames);
            searchPage.SearchSubmit();

            Assert.AreEqual(SearchResultPage.FirstLine, "Sidenko Alexander Olegoeich");
        }

        [TestMethod]
        public void Cannot_Search_Nonexistent_User()
        {
            #region TestData
            const string firstAndLastNames = "Ssdhcahcfo Trtr";
            #endregion

            var searchPage = new SearchResultPage();
            searchPage.FillSearchField(firstAndLastNames);
            searchPage.SearchSubmit();

            Assert.AreEqual(SearchResultPage.IsAtOnEmptyTable, "");
        }
    }
}
