using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using ProyectoCalidad.Source.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoCalidad.Tests
{
    internal class IntegrationWithDayDeals
    {
        private IWebDriver driver;

        [SetUp]
        public void initScript()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-blink-features=AutomationControlled");
            options.AddArgument("--start-maximized");
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);
        }

        [Test]
        public void validateRedirect()
        {
            HomePage home = new HomePage(driver);
            driver.Navigate().GoToUrl("https://www.bestbuy.com/?intl=nosplash");
            home.goToTopDeals();
            BestDeals todayDeal = new BestDeals(driver);
            todayDeal.goToTopDealsGames();
            Assert.True(this.driver.Url.Equals("https://www.bestbuy.com/site/tvs/smart-tvs/pcmcat220700050011.c?id=pcmcat220700050011"));
        }
    }
}
