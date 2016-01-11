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
            PersonsListPage.SearchPerson("Sidenko Alexander").Search();
            PersonsListPage.ChoosePerson();
            OnlyCreatedProfilePage.Delete();
            PersonsListPage.SecondSearch();

            Assert.IsFalse(PersonsListPage.IsAtInEmptyTable, "Your account was not deleted");
        }
    }
}
