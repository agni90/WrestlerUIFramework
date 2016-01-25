using Microsoft.VisualStudio.TestTools.UnitTesting;
using StreamtvFramework;
using OpenQA.Selenium;

namespace StreamtvTest
{
    [TestClass]
    public class CreateAccountTest : BaseTest
    {
        [TestMethod]
        public void Can_Create_Account_With_Valid_Data()
        {
            var testWrestler = new Wrestler
            {
                lname = "Siredenko",
                fname = "Alexander",
                dob = "12-12-1998",
                mname = "Olegoeich",
            };
            var page = new NewWrestlerPage();
            page.ClickNewUserButton();
            page.FillFields(testWrestler);
            page.SubmitNewWrestlerAccount();
            page.WaitForWrestlerTitleChanged();

            var profilePage = new ProfilePage();

            Assert.AreEqual(profilePage.wrestlerTitleElement.Text, "Siredenko A.O.");
        }

        [TestMethod]
        public void Cannot_Create_Account_When_Fields_Are_Empty()
        {
            var testWrestler = new Wrestler
            {
                lname = "",
                fname = "",
                dob = "",
                mname = "",
            };
            var page = new NewWrestlerPage();
            page.ClickNewUserButton();
            page.FillFields(testWrestler);
            Assert.IsTrue(page.greenButtonElement.Enabled == false);
        }

        [TestMethod]
        public void Cannot_Create_Account_When_One_Field_Is_Empty()
        {
            var testWrestler = new Wrestler
            {
                lname = "",
                fname = "Alexander",
                dob = "12-12-1998",
                mname = "Olegoeich",
            };
            var page = new NewWrestlerPage();
            page.ClickNewUserButton();
            page.FillFields(testWrestler);
            Assert.IsTrue(page.greenButtonElement.Enabled == false);
            }
        }
}
