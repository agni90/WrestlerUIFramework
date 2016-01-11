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
            PersonsListPage.SearchPerson("Siiidenko Alexander").Search();

            Assert.IsTrue(PersonsListPage.IsAt, "Your person was not found");
        }

        [TestMethod]
        public void Cannot_Search_Nonexistent_User()
        {
            PersonsListPage.SearchPerson("Ssdhcahcfo").Search();

            Assert.IsTrue(PersonsListPage.IsAtOnEmptyTable, "Your person was not found");
        }
    }
}
