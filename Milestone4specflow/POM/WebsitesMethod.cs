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
    class WebsitesMethod
    {
        public static void NavigateURL()
        {
            DriverMethod.driver.Manage().Window.Maximize();
            DriverMethod.driver.Navigate().GoToUrl(Spreadsheet.excelRead(1, 1));
            lognet.log.Info("NavigateURL");
        }
        public static void Searchbox()
        {
            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//button[@class='o-navbar-label js-search-btn']")).Click();
            lognet.log.Info("Searchbox");
        }
        public static void TypeShampooSearch()
        {
            Thread.Sleep(3000);
            IWebElement  Shampoo = DriverMethod.driver.FindElement(By.XPath("/html/body/div[1]/header/div[2]/div[1]/div/div/div/div/div/div/form/div[2]/div/span/input"));
            Shampoo.SendKeys("Shampoo");
            Shampoo.SendKeys(Keys.Enter);
            lognet.log.Info("Shampoo");
        }
        public static void Searchresults()
        {
            Thread.Sleep(5000);
            string text = DriverMethod.driver.FindElement(By.XPath("/html/body/div[1]/section/div/div/div/div/div[5]/ul/li[1]/div[2]/div/div/a/div[1]/h2")).Text;
            Thread.Sleep(2000);
            Assert.That(text,Is.EqualTo("Baby Shampoo"));         
            lognet.log.Info("Search results");
        }
        public static void givencapture()
        {
            Thread.Sleep(2000);
            CaputreImage.Cp("Search capture");
            lognet.log.Info("given capture");
        }
    }

}
