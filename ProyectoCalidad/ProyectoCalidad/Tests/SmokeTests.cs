using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProyectoCalidad.Source.Pages;

namespace ProyectoCalidad.Tests
{
    public class SmokeTests
    {
        private IWebDriver driver;
        private IJavaScriptExecutor js;

        [SetUp]
        public void Init()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-blink-features=AutomationControlled");
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);
        }

        [Test]
        public void LoadingHomePageInLessThanTenSeconds()
        {
            HomePage homePage = new HomePage(driver);
            this.driver.Navigate().GoToUrl("https://www.bestbuy.com/?intl=nosplash");

            this.js = (IJavaScriptExecutor)driver;
            decimal responseTime = Convert.ToDecimal(js.ExecuteScript("return window.performance.timing.domContentLoadedEventEnd-window.performance.timing.navigationStart;"));
            responseTime = responseTime / 1000;

            Assert.LessOrEqual(responseTime, 10);
            this.driver.Close();
        }

        [Test]
        public void CreateUserAccountPageIsDisplayed()
        {
            this.driver.Navigate().GoToUrl("https://www.bestbuy.com/identity/global/createAccount");

            this.js = (IJavaScriptExecutor)driver;
            bool wasDisplayed = js.ExecuteScript("return document.readyState").ToString().Equals("complete");

            Assert.IsTrue(wasDisplayed);
            this.driver.Close();
        }

        [Test]
        public void CategoryListPageIsDisplayed()
        {
            HomePage homePage = new HomePage(driver);
            this.driver.Navigate().GoToUrl("https://www.bestbuy.com/?intl=nosplash");

            IList<IWebElement> elements = driver.FindElements(By.CssSelector("#widget-c43f62dd-fbbd-42ce-b077-c7e701007da5 > div > div.sale-event-grid-wrapper.rows-3 > div"));
            Assert.GreaterOrEqual(elements.Count, 18);
            this.driver.Close();
        }
    }
}
