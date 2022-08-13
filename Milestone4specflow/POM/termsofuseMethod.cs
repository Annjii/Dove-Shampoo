using Milestone4specflow.Drivers;
using Milestone4specflow.Screenshot;
using Milestone4specflow.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Milestone4specflow.POM
{
    class termsofuseMethod
    {
        public static IJavaScriptExecutor js;
        public static void NavigateURL()
        {
            DriverMethod.driver.Manage().Window.Maximize();
            DriverMethod.driver.Navigate().GoToUrl(Spreadsheet.excelRead(1, 1));
            lognet.log.Info("NavigateURL");
        }
        public static void Scrolltonavigate()
        {
            js = (IJavaScriptExecutor)DriverMethod.driver;
            Thread.Sleep(5000);
            int locationY_OfElement = DriverMethod.driver.FindElement(By.XPath("/html/body/div[1]/section/footer/div/div[1]/div/div/div[2]/div/ul/li[3]/ul/li[2]/a")).Location.Y;

            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0, " + locationY_OfElement + ")");
            lognet.log.Info("Scrolltonavigate");
        }
        public static void clickonterms()
        {
            Thread.Sleep(5000);
            DriverMethod.driver.FindElement(By.XPath("/html/body/div[1]/section/footer/div/div[1]/div/div/div[2]/div/ul/li[3]/ul/li[2]/a")).Click();
            lognet.log.Info("Click on terms of use");
        }
        public static void prohibiteduses()
        {
            Thread.Sleep(5000);
            string text = DriverMethod.driver.FindElement(By.XPath("/ html / body / div[1] / section / div[1] / div / div / div / div / p[3] / b")).Text;
            Thread.Sleep(2000);
            Assert.That(text, Is.EqualTo("2. Prohibited Uses"));
            lognet.log.Info("prohibiteduses");
        }
        public static void termsofusecapture()
        {
            Thread.Sleep(2000);
            CaputreImage.Cp("Search capture");
            lognet.log.Info("terms of use");
        }

    }
}
