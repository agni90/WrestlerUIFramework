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
            PersonsListPage
                .EnterLastAndFirstNames("Sidenko Alexander")
                .Search();
            PersonsListPage.ChoosePersonFromSearchList();
            ProfilePage.DownloadPhoto();
            PersonsListPage.GotoWreslerTab();
            PersonsListPage.SecondSearch();

            Assert.IsTrue(PersonsListPage.DoesPhotoLabelChanged, "Photo was not downloaded. Please, try again");
        }
    }
}
