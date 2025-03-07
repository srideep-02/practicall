using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Dispose();
            driver.Quit();
        }
        [Test]
        public void calculator()
        {
            driver.Navigate().GoToUrl("https://www.calculator.net/percent-calculator.html");
            driver.FindElement(By.Id("cpar1")).Click();
            driver.FindElement(By.Id("cpar1")).SendKeys("100");
            driver.FindElement(By.Id("cpar2")).Click();
            driver.FindElement(By.Id("cpar2")).SendKeys("5");
            driver.FindElement(By.Id("cpar2")).SendKeys(Keys.Enter);

        }
    }
}