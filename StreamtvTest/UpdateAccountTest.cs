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
            PersonsListPage.SearchPerson("Sidenko Alexander").Search();
            PersonsListPage.ChoosePerson();
            ProfilePage.DownloadPhoto();
            PersonsListPage.Goto();
            PersonsListPage.SecondSearch();

            Assert.IsTrue(PersonsListPage.DoesPhotoLabelChanged, "Photo was not downloaded. Please, try again");
        }
    }
}
