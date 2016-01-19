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
            #region TestData

            const string lname = "Siiidenko";
            const string fname = "Alexander";
            const string dob = "12-12-1998";
            const string mname = "Olegoeich";
            const string region = "Volynska";
            const string fst = "Dinamo";
            const string style = "FS";
            const string age = "Senior";
            const string year = "2017"; 

            #endregion
            //press New button
            OnlyCreatedProfilePage.Goto();

            //fills all fields
            OnlyCreatedProfilePage
                .EnterLastName(lname)
                .EnterFirstName(fname)
                .EnterDOB(dob)
                .EnterMiddleName(mname)
                .ChooseRegion(region)
                .ChooseFST(fst)
                .ChooseStyle(style)
                .ChooseAge(age)
                .ChooseYear(year)
                .Create();

            Assert.IsTrue(ProfilePage.IsAt, "Profile was not created. Please, try again");
        }

        [TestMethod]
        [ExpectedException(typeof(WebDriverException))]
        public void Cannot_Create_Account_When_Fields_Are_Empty()
        {
            #region TestData

            const string lname = "";
            const string fname = "";
            const string dob = "";
            const string mname = "";
            const string region = "Volynska";
            const string fst = "Dinamo";
            const string style = "FS";
            const string age = "Senior";
            const string year = "2017";

            #endregion
            OnlyCreatedProfilePage.Goto();

            OnlyCreatedProfilePage
                .EnterLastName(lname)
                .EnterFirstName(fname)
                .EnterDOB(dob)
                .EnterMiddleName(mname)
                .ChooseRegion(region)
                .ChooseFST(fst)
                .ChooseStyle(style)
                .ChooseAge(age)
                .ChooseYear(year)
                .Create();


            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(WebDriverException))]
        public void Cannot_Create_Account_When_One_Field_Is_Empty()
        {
            #region TestData

            const string lname = "";
            const string fname = "Alexander";
            const string dob = "12-12-1998";
            const string mname = "Olegoeich";
            const string region = "Volynska";
            const string fst = "Dinamo";
            const string style = "FS";
            const string age = "Senior";
            const string year = "2017";

            #endregion
            OnlyCreatedProfilePage.Goto();

            OnlyCreatedProfilePage
                .EnterLastName(lname)
                .EnterFirstName(fname)
                .EnterDOB(dob)
                .EnterMiddleName(mname)
                .ChooseRegion(region)
                .ChooseFST(fst)
                .ChooseStyle(style)
                .ChooseAge(age)
                .ChooseYear(year)
                .Create();

            Assert.Fail();
        }
    }
}
