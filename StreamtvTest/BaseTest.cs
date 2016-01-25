using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StreamtvFramework;

namespace StreamtvTest
{
    public class BaseTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            var loginPage = new LoginPage();
            loginPage.GotoLoginPage();
            loginPage.EnterLogin("auto");
            loginPage.EnterPassword("test");
            loginPage.SubmitWrestlerCreation();
        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.CleanUp();
        }
    }
}
