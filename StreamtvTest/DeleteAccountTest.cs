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

            PersonsListPage
                .EnterLastAndFirstNames(firstAndLastNames)
                .Search();
            PersonsListPage.ChoosePersonFromSearchList();
            OnlyCreatedProfilePage.DeleteUser();
            PersonsListPage.SecondSearch();

            Assert.IsFalse(PersonsListPage.IsAtInEmptyTable, "Your account was not deleted");
        }
    }
}
