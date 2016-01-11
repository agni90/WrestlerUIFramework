using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StreamtvFramework;

namespace StreamtvTest
{
    [TestClass]
    public class CreateAccountTest : BaseTest
    {
        [TestMethod]
        public void Can_Create_Account_With_Valid_Data()
        {
            //press New button
            OnlyCreatedProfilePage.Goto();

            //fills all fields
            OnlyCreatedProfilePage.CreateWithLastName("Sidenko").WithFirstName("Alexander").WithDOB("12-12-1998")
                .WithMiddleName("Olegoeich").WithRegion("Volynska").WithFST("Dinamo")
                .WithStyle("FS").WithAge("Senior").WithYear("2017").Create();

            Assert.IsTrue(ProfilePage.IsAt, "Profile was not created. Please, try again");
        }
    }
}
