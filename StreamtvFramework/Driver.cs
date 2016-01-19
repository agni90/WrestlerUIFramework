using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace StreamtvFramework
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            var ffbinary = new FirefoxBinary(@"C:\Program Files (x86)\Mozilla Firefox\firefox.exe"); //for Windows 10
            Instance = new FirefoxDriver(ffbinary, new FirefoxProfile());
            //Instance = new FirefoxDriver();
            Instance.Manage()
            .Timeouts()
            .ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        public static void CleanUp()
        {
            Instance.Close();
        }

        public static void WaitElementUntilItVisible(string xpath, int seconds)
        {
            if (Instance != null)
            {
                var sleep = new WebDriverWait(Instance, TimeSpan.FromSeconds(seconds));
                sleep.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
            }
        }

        public static void WaitElementUntilTextChanged(string xpath, int seconds)
        {
            if (Instance != null)
            {
                var sleep = new WebDriverWait(Instance, TimeSpan.FromSeconds(seconds));
                sleep.Until(ExpectedConditions.InvisibilityOfElementWithText(By.XPath(xpath), "New Wrestler"));
            }
        }
    }
}