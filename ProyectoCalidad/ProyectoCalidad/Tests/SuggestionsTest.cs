using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProyectoCalidad.Source.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace ProyectoCalidad.Tests
{
    public class SuggestionsTest
    {
        private IWebDriver driver;

        [SetUp]
        public void initScript()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);
        }

        [Test]
        public void validateSuggestions()
        {
            SuggestionsSearchesPage page = new SuggestionsSearchesPage(driver);
            driver.Navigate().GoToUrl("https://www.bestbuy.com/?intl=nosplash");
            page.validateSuggestion("headphones wireless noise cancel");
            Thread.Sleep(3000);
            Assert.True(this.driver.Title.Contains("headphones wireless noise cancel - Best Buy"));
        }

        [Test]
        public void validateSuggestionsIncorrect()
        {
            SuggestionsSearchesPage page = new SuggestionsSearchesPage(driver);
            driver.Navigate().GoToUrl("https://www.bestbuy.com/?intl=nosplash");
            page.validateSuggestion("heahones wireless noise cancel");
            Thread.Sleep(3000);
            Assert.True(this.driver.Title.Contains("headphones wireless noise cancel - Best Buy"));
        }

        [TearDown]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}
