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
            PersonsListPage.SearchPerson("Sidenko Alexander").Search();

            Assert.IsTrue(PersonsListPage.IsAt, "Your person was not found");
        }
	}
}
