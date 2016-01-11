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
            LoginPage.Goto();
            LoginPage.LoginAs("auto").WithPassword("test").Login();
        }

        //[TestCleanup]
       // public void CleanUp()
       // {
          //  Driver.CleanUp();
        //}
    }
}
