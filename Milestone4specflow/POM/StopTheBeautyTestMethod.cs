using Milestone4specflow.Drivers;
using Milestone4specflow.Hooks;
using Milestone4specflow.Screenshot;
using Milestone4specflow.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Milestone4specflow.POM
{
    class StopTheBeautyTestMethod
    {
        public static IJavaScriptExecutor js;
        public static void NavigateURL()
        {
            DriverMethod.driver.Manage().Window.Maximize();
            DriverMethod.driver.Navigate().GoToUrl(Spreadsheet.excelRead(1, 1));
            lognet.log.Info("NavigateURL");
        }
        public  static void Scrolltonavigate()
        {
            js = (IJavaScriptExecutor)DriverMethod.driver;
          
            Thread.Sleep(5000);
            int locationY_OfElement = DriverMethod.driver.FindElement(By.XPath("//h1[contains(text(),'Welcome to Dove...')]")).Location.Y;

            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0, " + locationY_OfElement + ")");
            lognet.log.Info("Scrolltonavigate");
        }
        public static void Clickondiscover()
        {
            Thread.Sleep(5000);
            DriverMethod.driver.FindElement(By.XPath("//a[contains(text(),'Discover more')]")).Click();
            lognet.log.Info("discover");
        }
        public static void Scrolltoshopthebeautytest()
        {
            js = (IJavaScriptExecutor)DriverMethod.driver;

            Thread.Sleep(5000);
            int locationY_OfElement = DriverMethod.driver.FindElement(By.XPath("/html/body/div[1]/section/div[1]/div[2]/div/div/div/div[1]/h2")).Location.Y;

            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0, " + locationY_OfElement + ")");
            lognet.log.Info("Scrolltoshopthebeautytest");
        }
        public static void verifyLetsStopTheBeautyTest()
        {
            Thread.Sleep(5000);
            string text = DriverMethod.driver.FindElement(By.XPath("/html/body/div[1]/section/div[1]/div[2]/div/div/div/div[1]/h2")).Text;
            Thread.Sleep(2000);
            Assert.That(text, Is.EqualTo("The Real Women behind #StopTheBeautyTest"));
            lognet.log.Info("LetsStopTheBeautyTest");
        }
        public static void StopTheBeautycapture()
        {
            Thread.Sleep(2000);
            CaputreImage.Cp("Search capture");
            lognet.log.Info("StopTheBeautycapture");
        }
    }
}
