using System;
using System.Windows.Forms;
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
            //press New button
            OnlyCreatedProfilePage.Goto();

            //fills all fields
            OnlyCreatedProfilePage
                .EnterLastName("Siiidenko")
                .EnterFirstName("Alexander")
                .EnterDOB("12-12-1998")
                .EnterMiddleName("Olegoeich")
                .ChooseRegion("Volynska")
                .ChooseFST("Dinamo")
                .ChooseStyle("FS")
                .ChooseAge("Senior")
                .ChooseYear("2017")
                .Create();

            Assert.IsTrue(ProfilePage.IsAt, "Profile was not created. Please, try again");
        }

        [TestMethod]
        [ExpectedException(typeof(WebDriverException))]
        public void Cannot_Create_Account_When_Fields_Are_Empty()
        {
            OnlyCreatedProfilePage.Goto();

            OnlyCreatedProfilePage.EnterLastName("").EnterFirstName("").EnterDOB("")
                .EnterMiddleName("").ChooseRegion("").ChooseFST("")
                .ChooseStyle("").ChooseAge("").ChooseYear("").Create();

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(WebDriverException))]
        public void Cannot_Create_Account_When_One_Field_Is_Empty()
        {
            OnlyCreatedProfilePage.Goto();

            OnlyCreatedProfilePage.EnterLastName("").EnterFirstName("Alexander").EnterDOB("12-12-1998")
                .EnterMiddleName("Olegoeich").ChooseRegion("Volynska").ChooseFST("Dinamo")
                .ChooseStyle("FS").ChooseAge("Senior").ChooseYear("2017").Create();

            Assert.Fail();
        }
    }
}
