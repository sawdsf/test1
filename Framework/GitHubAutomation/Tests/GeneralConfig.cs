using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using NUnit.Framework;
using log4net;
using log4net.Config;
using GitHubAutomation.Driver;

namespace GitHubAutomation.Tests
{
    public class GeneralConfig : Logger
    {
        private static readonly NLog.Logger _log_ = NLog.LogManager.GetCurrentClassLogger();

        protected IWebDriver Driver;
        //protected IWebDriver Driver1;
        [SetUp]
        public void SetDriver()
        {
            Driver = DriverSingleton.GetDriver();
            Driver.Navigate().GoToUrl("https://www.hotelreservierung.de/");
            Driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 5);
            Driver.Manage().Window.Maximize();
            //Driver1 = DriverSingleton.GetDriver();
            //Driver1.Navigate().GoToUrl("https://login.hotelreservierung.de");
            //Driver1.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 5);
            //Driver1.Manage().Window.Maximize();
        }

        protected void TakeScreenshotWhenTestFailed(Action action)
        {
            try
            {
                action();
            }
            catch
            {
                var screenshotFolder = AppDomain.CurrentDomain.BaseDirectory + @"\screenshots";
                Directory.CreateDirectory(screenshotFolder);
                var screenshot = Driver.TakeScreenshot();
                screenshot.SaveAsFile(screenshotFolder + @"\screenshot"
                                                       + DateTime.Now.ToString("yy-MM-dd_hh-mm-ss") + ".png",
                                                       ScreenshotImageFormat.Png);
                _log_.Error("Test_Failure");
            }
        }

        [TearDown]
        public void QuitDriver()
        {
            Log.Info("Test_Successfully");
            DriverSingleton.CloseDriver();
        }
    }
}
